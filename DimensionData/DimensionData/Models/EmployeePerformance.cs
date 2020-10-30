using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimensionData.Models
{
    public partial class EmployeePerformance
    {
        public EmployeePerformance()
        {
            Employee = new HashSet<Employee>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpPerformanceId { get; set; }
        public int? PerformanceRating { get; set; }
        public int? WorkLifeBalance { get; set; }
        public int? JobInvolvement { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
