using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DimensionData.Models
{
    public class EmployeeModel
    {
        //Used in Main Table    
        [Key]
        public int ListID { get; set; }
        [Display(Name = "Employee Number")]
        public int EmployeeNumber { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public string JobRole { get; set; }
        [Display(Name = "Job Level")]
        public int JobLevel { get; set; }

        //Used in Details
        [Display(Name = "Years At Company")]
        public int YearsAtCompany { get; set; }
        public Boolean Attrition { get; set; }
        public string BusinessTravel { get; set; }
        public decimal DailyRate { get; set; }
        public int DistanceFromHome { get; set; }
        public int Education { get; set; }
        public string EducationField { get; set; }
        public int EmployeeCount { get; set; }
        public int EnvironmentSatisfaction { get; set; }
        public decimal HourlyRate { get; set; }
        public int JobInvolvement { get; set; }
        public int JobSatisfaction { get; set; }
        public string MaritalStatus { get; set; }
        public decimal MonthlyIncome { get; set; }
        public decimal MonthlyRate { get; set; }
        public int NumCompaniesWorked { get; set; }
        public Boolean Over18 { get; set; }
        public Boolean OverTime { get; set; }
        public decimal PercentSalaryHike { get; set; }
        public int PerformanceRating { get; set; }
        public int RelationshipSatisfaction { get; set; }
        public int StandardHours { get; set; }
        public int StockOptionLevel { get; set; }
        public int TotalWorkingYears { get; set; }
        public int TrainingTimesLastYear { get; set; }
        public int WorkLifeBalance { get; set; }
        public int YearsInCurrentRole { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int YearsWithCurrManager { get; set; }
    }
}
