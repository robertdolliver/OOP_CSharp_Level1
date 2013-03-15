using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_ClassDevelopment
{
    public static class Statistics
    {
        #region Math Routines

        public static decimal Add(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            return total;
        }

        public static decimal Divide(decimal num1, decimal num2)
        {
            try
            {
                decimal total = num1 / num2;
                return total;
            }
            catch (DivideByZeroException)
            {
                throw new Exception("You cannot have a zero in the denominator");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
