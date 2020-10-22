using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        ICollection<Student> Student { get; set; }
    }
}
