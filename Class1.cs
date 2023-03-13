using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingWithTheDelegates
{
    public static class Class1
    {
        public static ShowHandler ShowDelegate = Program.Show;

        public static int Pow(int firstValue, int secondValue)
        {
            int result = firstValue * secondValue;
            return result;
        }
    }
}
