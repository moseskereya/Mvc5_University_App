using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfCourses { get; set; }
        public decimal Salary { get; set; }
        public DateTime Datestarted { get; set; }
    }
}