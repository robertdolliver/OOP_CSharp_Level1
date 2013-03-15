using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_ClassDevelopment
{
    public class Employee
    {
        #region Constructors
        
        //Empty Constructor
      public Employee(){}


        //Overload the Constructors
        public Employee(int id)
        {
            EmployeeID = id;
        }
        public Employee(int i, string f, string l, DateTime h)
        {
            EmployeeID = i;
            LastName = l;
            FirstName = f;
            HireDate = h;
        }
        
        #endregion

        #region Fields and Properties
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

        private DateTime _HireDate;
        public DateTime HireDate
        {
            get { return _HireDate; }
            set 
            { 
                if(value <= DateTime.Now)
                {
                    _HireDate = value; 
                }
                else
                {
                    throw new Exception("Invalid Hire-Date");
                }
            }
        }
        
        //calculated (Read-Only) Fields 
        public string EmployeeName
        {
            get { return FullName(); }
        }
        #endregion

        #region Methods
        public string EmployeeInfo(string sep)
        {
            string info =
                string.Format("{0}{1}{2}{3}{4:D}{5}{6:c}",EmployeeID.ToString(),
                              sep,FullName(),sep,HireDate,sep,EmployeeSales(EmployeeID));
            return info;
        }

        public string FullName()
        {
            return _FirstName + " " + _LastName;
        }

        public static decimal EmployeeSales(int id)
        {
            Random rnd = new Random();
            decimal total = rnd.Next(0, 20000);
            return total;
        }

        #endregion
    }
}
