using System;
using System.Collections.Generic;

namespace DimensionData.Models
{
    public partial class Employee
    {
        public int EmployeeNumber { get; set; }
        public int PayId { get; set; }
        public int EmpId { get; set; }
        public int EmpHistoryId { get; set; }
        public int EduId { get; set; }
        public int SurveyId { get; set; }
        public int EmpPerformanceId { get; set; }
        public int JobId { get; set; }

        public virtual EmployeeEducation Edu { get; set; }
        public virtual EmployeeDetails Emp { get; set; }
        public virtual EmployeeHistory EmpHistory { get; set; }
        public virtual EmployeePerformance EmpPerformance { get; set; }
        public virtual JobInformation Job { get; set; }
        public virtual CostToCompany Pay { get; set; }
        public virtual Surveys Survey { get; set; }
    }
}
