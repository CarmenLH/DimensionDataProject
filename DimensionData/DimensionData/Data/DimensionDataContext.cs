﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DimensionData.Models;

namespace DimensionData.Data
{
    public partial class DimensionDataContext : DbContext
    {
        public DimensionDataContext()
        {
        }

        public DimensionDataContext(DbContextOptions<DimensionDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CostToCompany> CostToCompany { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public virtual DbSet<EmployeeEducation> EmployeeEducation { get; set; }
        public virtual DbSet<EmployeeHistory> EmployeeHistory { get; set; }
        public virtual DbSet<EmployeePerformance> EmployeePerformance { get; set; }
        public virtual DbSet<JobInformation> JobInformation { get; set; }
        public virtual DbSet<Surveys> Surveys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Initial Catalog=DimensionData;Data Source=DESKTOP-SS18BBC\\SQLEXPRESS;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<CostToCompany>(entity =>
            {
                entity.HasKey(e => e.PayId);

                entity.Property(e => e.DailyRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HourlyRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MonthlyIncome).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MonthlyRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PercentSalaryHike).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeNumber);

                entity.Property(e => e.EduId).HasColumnName("EduID");

                entity.Property(e => e.EmpHistoryId).HasColumnName("empHistoryID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EmpPerformanceId).HasColumnName("empPerformanceID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.PayId).HasColumnName("PayID");

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.HasOne(d => d.Edu)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EduId)
                    .HasConstraintName("FK_Employee_EmployeeEducation");

                entity.HasOne(d => d.EmpHistory)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmpHistoryId)
                    .HasConstraintName("FK_Employee_EmployeeHistory");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_Employee_EmployeeDetails");

                entity.HasOne(d => d.EmpPerformance)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmpPerformanceId)
                    .HasConstraintName("FK_Employee_EmployeePerformance");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Employee_JobInformation");

                entity.HasOne(d => d.Pay)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PayId)
                    .HasConstraintName("FK_Employee_CostToCompany");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.SurveyId)
                    .HasConstraintName("FK_Employee_Surveys");
            });

            modelBuilder.Entity<EmployeeDetails>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Gender)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeEducation>(entity =>
            {
                entity.HasKey(e => e.EduId);

                entity.Property(e => e.EduId).HasColumnName("EduID");

                entity.Property(e => e.EducationField)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeHistory>(entity =>
            {
                entity.HasKey(e => e.EmpHistoryId);

                entity.Property(e => e.EmpHistoryId).HasColumnName("empHistoryID");
            });

            modelBuilder.Entity<EmployeePerformance>(entity =>
            {
                entity.HasKey(e => e.EmpPerformanceId);

                entity.Property(e => e.EmpPerformanceId).HasColumnName("empPerformanceID");
            });

            modelBuilder.Entity<JobInformation>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.BusinessTravel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Surveys>(entity =>
            {
                entity.HasKey(e => e.SurveyId);

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
