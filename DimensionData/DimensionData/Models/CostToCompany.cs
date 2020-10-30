using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimensionData.Models
{
    public partial class CostToCompany
    {
        public CostToCompany()
        {
            Employee = new HashSet<Employee>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayId { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? MonthlyRate { get; set; }
        public decimal? MonthlyIncome { get; set; }
        public decimal? DailyRate { get; set; }
        public bool? OverTime { get; set; }
        public decimal? PercentSalaryHike { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
