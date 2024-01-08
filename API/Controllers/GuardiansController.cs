using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using test2.Models;

namespace test2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardiansController: ControllerBase
    {
        private readonly SurveyDBContext _context;
        private IConfiguration _configuration;
        private IDbContextTransaction _transaction;

        public GuardiansController(SurveyDBContext context, IConfiguration iconfig, bool embeddedTransaction = false, IDbContextTransaction? contextTransaction = null)
        {
            _context = context;
            _configuration = iconfig;
            _transaction = embeddedTransaction ? contextTransaction! : context.Database.BeginTransaction();
        }

        // GET: api/Guardians
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guardians>>> GetGuardians()
        {
          if (_context.Guardians == null)
          {
              return NotFound();
          }
            return await _context.Guardians.ToListAsync();
        }

        // GET: api/QAndAs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<QAndA>>> GetQAndA(int id)
        {
            if (_context.QAndA == null)
            {
                return NotFound();
            }
            var qAndA = await _context.QAndA.Where(q => q.Sdid == id).ToListAsync();

            if (qAndA.Last() == null)
            {
                return NotFound();
            }

            return qAndA;
        }

        // PUT: api/Guardians/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuardians(int id, string apikey, Guardians guardians)
        {
            if (!apikey.Equals(_configuration.GetValue<string>("AdminKey"))) return Unauthorized("Please supply valid API key");

            guardians.GuardianId = id;

            if (id != guardians.GuardianId)
            {
                return BadRequest();
            }

            _context.Entry(guardians).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                await _transaction.RollbackAsync();
                if (!GuardiansExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Guardians
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{apikey}")]
        public async Task<ActionResult<Guardians>> PostGuardians(IEnumerable<Guardians> guardians, string apikey)
        {
            if (!apikey.Equals(_configuration.GetValue<string>("GeneralSurveyKey"))) return Unauthorized("Please supply valid API key");

            try {
                foreach (Guardians guard in guardians)
                {
                    if (_context.Guardians == null)
                    {
                        return Problem("Entity set 'SurveyDBContext.Guardians'  is null.");
                    }
                    _context.Guardians.Add(guard);

                }

                await _context.SaveChangesAsync();
                await _transaction.CommitAsync();
                return Ok();
            }
            catch (Exception e)
            {
                await _transaction.RollbackAsync();
                return BadRequest(e);
            }
        }

        private bool GuardiansExists(int id)
        {
            return (_context.Guardians?.Any(e => e.GuardianId == id)).GetValueOrDefault();
        }
    }
}
