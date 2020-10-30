using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimensionData.Models
{
    public partial class Surveys
    {
        public Surveys()
        {
            Employee = new HashSet<Employee>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SurveyId { get; set; }
        public int? EnvironmentSatisfaction { get; set; }
        public int? JobSatisfaction { get; set; }
        public int? RelationshipSatisfaction { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
