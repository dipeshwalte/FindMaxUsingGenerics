using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGenerics
{
    public class FindMaximum<T> where T:IComparable
    {
        public T FindMaximumNumber(T num1, T num2, T num3)
        {
            
            if (num1.CompareTo(num2)>0&&num1.CompareTo(num3)>0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            throw new FindMaximumException("All Values are Same");
        }


    }
}
