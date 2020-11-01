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
        public decimal? HourlyRate { get; set; }
        [DataType(DataType.Currency)]
        public decimal? MonthlyRate { get; set; }
        [DataType(DataType.Currency)]
        public decimal? MonthlyIncome { get; set; }
        [DataType(DataType.Currency)]
        public decimal? DailyRate { get; set; }
        [DataType(DataType.Currency)]
        public bool? OverTime { get; set; }
        [DataType(DataType.Currency)]
        public decimal? PercentSalaryHike { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
