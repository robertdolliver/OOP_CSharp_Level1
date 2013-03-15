using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08ClassDevelopment
{
    public class Employee
    {
        //Field: Bound to a Property
        private int _EmployeeID;
        public int EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }

        }

        private string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        private DateTime _Hiredate;
        public DateTime Hiredate
        {
            get { return _Hiredate; }
            set 
            { 
                if(value <= DateTime.Now)
                {
                    _Hiredate = value; 
                }
                else
                {
                    throw new Exception("Invalid Hire-Date");
                }
            
            }
        }

    }
}
