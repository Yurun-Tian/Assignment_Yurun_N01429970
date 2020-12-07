using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_Yurun_N01429970.Models
{
    public class Course
    {
        //The following fields define an Course
        public int CourseId;
        public string CourseCode;
        public DateTime StartDate;
        public DateTime FinishDate;
        public string CourseName;
        public Teacher Instructor;
    }
}