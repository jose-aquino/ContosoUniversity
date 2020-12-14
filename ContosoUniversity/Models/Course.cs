using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Member ID")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Speaker's Name")]
        public string Title { get; set; }
        [Range(0, 60)]
        [Display(Name = "Time/Minutes")]
        public int Credits { get; set; }
        public int DepartmentID { get; set; }

        [Display(Name = "Subject")]
        public Department Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }

    }
}