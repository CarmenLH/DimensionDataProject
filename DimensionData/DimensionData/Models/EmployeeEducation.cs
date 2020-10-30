using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimensionData.Models
{
    public partial class EmployeeEducation
    {
        public EmployeeEducation()
        {
            Employee = new HashSet<Employee>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EduId { get; set; }
        public int? Education { get; set; }
        public string EducationField { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
