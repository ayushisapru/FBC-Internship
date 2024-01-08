// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace test2.Models
{
    public partial class SurveyDBContext : DbContext
    {
        public SurveyDBContext()
        {
        }

        public SurveyDBContext(DbContextOptions<SurveyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalPeople> AdditionalPeople { get; set; } = null!;
        public virtual DbSet<Gaurdians> Gaurdians { get; set; } = null!;
        public virtual DbSet<Interviewers> Interviewers { get; set; } = null!;
        public virtual DbSet<QAndA> QAndA { get; set; } = null!;
        public virtual DbSet<Questions> Questions { get; set; } = null!;
        public virtual DbSet<SurveyInfo> SurveyInfo { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalPeople>(entity =>
            {
                entity.HasKey(e => e.AdditionalId);

                entity.ToTable("Additional_people");

                entity.Property(e => e.AdditionalId)
                .HasColumnName("Additional_id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.AdditionalEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Additional_email");

                entity.Property(e => e.AdditionalFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Additional_first_name");

                entity.Property(e => e.AdditionalLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Additional_last_name");

                entity.Property(e => e.AdditionalPhone)
                    .HasColumnName("Additional_phone")
                    .HasDefaultValueSql("((0.))");

                entity.Property(e => e.Sdid).HasColumnName("SDID");

                entity.Property(e => e.UserCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_created");

                entity.Property(e => e.UserCreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("User_created_date")
                    .HasDefaultValueSql("(getdate())")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserUpdated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_updated");

                entity.Property(e => e.UserUpdatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_updated_date_time");

                entity.HasOne(d => d.Sd)
                    .WithMany(p => p.AdditionalPeople)
                    .HasForeignKey(d => d.Sdid)
                    .HasConstraintName("FK_Additional_people_Survey_Info");
            });

            modelBuilder.Entity<Gaurdians>(entity =>
            {
                entity.HasKey(e => e.GaurdianId);

                entity.Property(e => e.GaurdianId)
                .HasColumnName("Gaurdian_id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.GaurdianEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Gaurdian_email");

                entity.Property(e => e.GaurdianFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Gaurdian_first_name");

                entity.Property(e => e.GaurdianLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Gaurdian_last_name");

                entity.Property(e => e.GaurdianPhone)
                    .HasColumnName("Gaurdian_phone")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sdid).HasColumnName("SDID");

                entity.Property(e => e.UserCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_created");

                entity.Property(e => e.UserCreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_created_date_time")
                    .HasDefaultValueSql("(getdate())")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserUpdated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_updated");

                entity.Property(e => e.UserUpdatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_updated_date_time");

                entity.HasOne(d => d.Sd)
                    .WithMany(p => p.Gaurdians)
                    .HasForeignKey(d => d.Sdid)
                    .HasConstraintName("FK_Gaurdians_Survey_Info");
            });

            modelBuilder.Entity<Interviewers>(entity =>
            {
                entity.HasKey(e => e.InterviewerId);

                entity.Property(e => e.InterviewerId)
                .HasColumnName("Interviewer_id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.InterviewerEmail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Interviewer_email");

                entity.Property(e => e.InterviewerFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Interviewer_first_name");

                entity.Property(e => e.InterviewerLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Interviewer_last_name");

                entity.Property(e => e.InterviewerPhone)
                    .HasColumnName("Interviewer_phone")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sdid).HasColumnName("SDID");

                entity.Property(e => e.UserCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_created");

                entity.Property(e => e.UserCreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_created_date_time")
                    .HasDefaultValueSql("(getdate())")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserUpdated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_updated");

                entity.Property(e => e.UserUpdatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_updated_date_time");

                entity.HasOne(d => d.Sd)
                    .WithMany(p => p.Interviewers)
                    .HasForeignKey(d => d.Sdid)
                    .HasConstraintName("FK_Interviewers_Survey_Info");
            });

            modelBuilder.Entity<QAndA>(entity =>
            {
                entity.HasKey(e => e.QaRecord);

                entity.ToTable("Q_and_A");

                entity.Property(e => e.QaRecord)
                .HasColumnName("QA_record")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Answer)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("Question_id");

                entity.Property(e => e.Sdid).HasColumnName("SDID");

                entity.Property(e => e.SurveyId).HasColumnName("Survey_id");

                entity.Property(e => e.UserCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_created");

                entity.Property(e => e.UserCreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_created_date_time")
                    .HasDefaultValueSql("(getdate())")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserUpdated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_updated");

                entity.Property(e => e.UserUpdatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_updated_date_time");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QAndA)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_Q_and_A_Questions");

                entity.HasOne(d => d.Sd)
                    .WithMany(p => p.QAndA)
                    .HasForeignKey(d => d.Sdid)
                    .HasConstraintName("FK_Q_and_A_Survey_Info");
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK_Questions_1");

                entity.Property(e => e.QuestionId)
                .HasColumnName("Question_id")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.QuestionDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Question_desc");

                entity.Property(e => e.UserCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_created");

                entity.Property(e => e.UserCreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_created_date_time")
                    .HasDefaultValueSql("(getdate())")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserUpdated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_updated");

                entity.Property(e => e.UserUpdatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_updated_date_time")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SurveyInfo>(entity =>
            {
                entity.HasKey(e => e.Sdid);

                entity.ToTable("Survey_Info");

                entity.Property(e => e.Sdid)
                .HasColumnName("SDID")
                .ValueGeneratedOnAdd();

                entity.Property(e => e.JuvenileFirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Juvenile_first_name");

                entity.Property(e => e.JuvenileLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Juvenile_last_name");

                entity.Property(e => e.SurveyAnswer)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Survey_answer");

                entity.Property(e => e.SurveyId).HasColumnName("Survey_id");

                entity.Property(e => e.UserCreated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_created");

                entity.Property(e => e.UserCreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_created_date_time")
                    .HasDefaultValueSql("(getdate())")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.UserUpdated)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_updated");

                entity.Property(e => e.UserUpdatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("User_updated_date_time");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}