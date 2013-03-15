using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_ClassDevelopment
{
    public class Course
    {
        //public string CourseName;

        //Field Property
        private string _CourseName;
        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }

        //Method
        public string GetCourseInfo()
        {
            return "";
        }
    }
}
