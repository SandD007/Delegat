using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingWithTheDelegates
{
    public static class Class2
    {
        public static PowHandler PowDelegate = Class1.Pow;

        public static ResultHandler ResultDelegate = Result;

        private static int result = 0;

        public static ResultHandler Calc(PowHandler delegat, int value1, int value2)
        {
            result = delegat(value1, value2);
            return ResultDelegate;
        }

        public static bool Result(int value)
        {
            if (result % value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
