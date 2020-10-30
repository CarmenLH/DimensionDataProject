using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimensionData.Models
{
    public partial class JobInformation
    {
        public JobInformation()
        {
            Employee = new HashSet<Employee>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }
        public string JobRole { get; set; }
        public string Department { get; set; }
        public int? JobLevel { get; set; }
        public string BusinessTravel { get; set; }
        public int? StockOptionLevel { get; set; }
        public int? EmployeeCount { get; set; }
        public int? StandardHours { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
