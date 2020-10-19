using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DimensionData.Models
{
    public class EmployeeModel
    {
        //Used in Main Table
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
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
        public bool Attrition { get; set; }
        public string BusinessTravel { get; set; }
        public double DailyRate { get; set; }
        public double DistanceFromHome { get; set; }
        public int Education { get; set; }
        public string EducationField { get; set; }
        public int EmployeeCount { get; set; }
        public int EnvironmentSatisfaction { get; set; }
        public double HourlyRate { get; set; }
        public int JobInvolvement { get; set; }
        public int JobSatisfaction { get; set; }
        public string MaritalStatus { get; set; }
        public double MonthlyIncome { get; set; }
        public double MonthlyRate { get; set; }
        public int NumCompaniesWorked { get; set; }
        public string Over18 { get; set; }
        public bool OverTime { get; set; }
        public double PercentSalaryHike { get; set; }
        public int PerformanceRating { get; set; }
        public int RelationshipSatisfaction { get; set; }
        public double StandardHours { get; set; }
        public int StockOptionLevel { get; set; }
        public double TotalWorkingYears { get; set; }
        public int TrainingTimesLastYear { get; set; }
        public int WorkLifeBalance { get; set; }
        public int YearsInCurrentRole { get; set; }
        public int YearsSinceLastPromotion { get; set; }
        public int YearsWithCurrManager { get; set; }
    }
}
