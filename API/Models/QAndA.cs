// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace test2.Models
{
    public partial class QAndA
    {
        [JsonIgnore]
        public int QaRecord { get; set; }
        public int Sdid { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public string? Answer { get; set; }
        public string UserCreated { get; set; } = null!;
        public DateTime UserCreatedDateTime { get; set; }
        public string? UserUpdated { get; set; }
        public DateTime? UserUpdatedDateTime { get; set; }

        [JsonIgnore]
        public virtual Questions? Question { get; } = null!;

        [JsonIgnore]
        public virtual SurveyInfo? Sd { get; } = null!;
    }
}
