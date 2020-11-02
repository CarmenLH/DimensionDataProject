using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DimensionData.Models;
using System.Threading.Tasks;
using System.Linq;

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

        #region Table Db Sets
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
        #endregion Table Db Sets

        #region SQL queries for Data

        //Get All employee information with pagination
        public async Task<PaginatedList<Employee>> GetAllPagination(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var employees = from s in Employee.Include(e => e.Edu).Include(e => e.Emp).Include(e => e.Job) select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(s => s.Job.Department.Contains(searchString)
                                       || s.Job.JobRole.Contains(searchString));
            }

            //Individual Sorting for each column
            switch (sortOrder)
            {
                case "EmpNr":
                    employees = employees.OrderBy(s => s.EmployeeNumber);
                    break;
                case "empnr_desc":
                    employees = employees.OrderByDescending(s => s.EmployeeNumber);
                    break;
                case "EmpAge":
                    employees = employees.OrderBy(s => s.Emp.Age);
                    break;
                case "empage_desc":
                    employees = employees.OrderByDescending(s => s.Emp.Age);
                    break;
                case "JobLevel":
                    employees = employees.OrderBy(s => s.Job.JobLevel);
                    break;
                case "joblevel_desc":
                    employees = employees.OrderByDescending(s => s.Job.JobLevel);
                    break;
                case "JobRole":
                    employees = employees.OrderBy(s => s.Job.JobRole);
                    break;
                case "jobrole_desc":
                    employees = employees.OrderByDescending(s => s.Job.JobRole);
                    break;
                case "Dep":
                    employees = employees.OrderBy(s => s.Job.Department);
                    break;
                case "dep_desc":
                    employees = employees.OrderByDescending(s => s.Job.Department);
                    break;
                case "Gender":
                    employees = employees.OrderBy(s => s.Emp.Gender);
                    break;
                case "gender_desc":
                    employees = employees.OrderByDescending(s => s.Emp.Gender);
                    break;
                default:
                    employees = employees.OrderBy(s => s.EmployeeNumber);
                    break;
            }

            int pageSize = 10;
            var pagedList = await PaginatedList<Employee>.CreateAsync(employees.AsNoTracking(), pageNumber ?? 1, pageSize);

            return pagedList;
        }

        //Get the details of each employee by id
        public async Task<Employee> GetbyIdAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await Employee
               .Include(e => e.Emp)
               .Include(e => e.Edu)
               .Include(e => e.EmpHistory)
               .Include(e => e.Job)
               .Include(e => e.Pay)
               .Include(e => e.Survey)
               .Include(e => e.EmpPerformance)
               .FirstOrDefaultAsync(m => m.EmployeeNumber == id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        //Edit the data of an employee
        public async Task<Employee> UpdateAsync(int? id, Employee employee)
        {
            if (id != employee.EmployeeNumber)
            {
                return NotFound();
            }

            try
            {
                Update(employee);
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(employee.EmployeeNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return employee;
        }

        //Create a new data entry
        public async Task<Employee> CreateAsync(Employee employee)
        {
            try
            {
                Employee.Add(employee);
                await SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeeExists(employee.EmployeeNumber))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return employee;
        }

        //Delete an existing data entry
        public async Task<Employee> DeleteAsync(int? id)
        {
            try
            {
                var employee = await Employee.FindAsync(id);
                Employee.Remove(employee);
                await SaveChangesAsync();

                return employee;
            }
            catch(DbUpdateConcurrencyException)
            {
                return NotFound();
            }
        }

        //Exception methods
        private Employee NotFound()
        {
            throw new NotImplementedException();
        }
        private bool EmployeeExists(int id)
        {
            return Employee.Any(e => e.EmployeeNumber == id);
        }

        #endregion SQL queries for Data

        #region Model Builder 
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
        #endregion Model Builder 
    }
}
