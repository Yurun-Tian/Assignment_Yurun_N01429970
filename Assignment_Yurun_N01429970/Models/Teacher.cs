﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_Yurun_N01429970.Models
{
    public class Teacher
    {
        //The following fields define an Teacher
        public int TeacherId;
        public string TeacherFname;
        public string TeacherLname;
        public string EmployeeNumber;
        public DateTime HireDate;
        public double Salary;
        public List<Course> ClassesTaught;
    }

}