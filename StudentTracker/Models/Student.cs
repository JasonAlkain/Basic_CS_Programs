using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTracker.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Student_FName { get; set; }
        public string Student_LName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime? DateOfBirth { get; set; }

        //fully defined relationship
        public int? GradeId { get; set; }
        public virtual string Course { get; set; }
    }
}
