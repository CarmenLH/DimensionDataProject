using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DimensionData.Models
{
    public partial class CostToCompany
    {
        public CostToCompany()
        {
            Employee = new HashSet<Employee>();
        }

        public int PayId { get; set; }
        [DataType(DataType.Currency)]
        public double? HourlyRate { get; set; }
        [DataType(DataType.Currency)]
        public double? MonthlyRate { get; set; }
        [DataType(DataType.Currency)]
        public double? MonthlyIncome { get; set; }
        [DataType(DataType.Currency)]
        public double? DailyRate { get; set; }
        [DataType(DataType.Currency)]
        public bool OverTime { get; set; }
        [DataType(DataType.Currency)]
        public double? PercentSalaryHike { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
