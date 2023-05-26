using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngAssesment.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; } 
        public string StudentName { get; set; } 

        public string Course { get; set; }

        public string Specialization { get; set; }   

        public int Percentage { get; set; } = 0;

        [ForeignKey("Departments")]
        public int DepartmentId { get; set; }
        public virtual Department Departments { get; set; }

    }
}
