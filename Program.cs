using System;

namespace SomethingWithTheDelegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var resultDelegate = Class2.Calc(Class2.PowDelegate, 2, 3);
            Show(resultDelegate);
        }

        public static void Show(ResultHandler value)
        {
            bool result = value(2);

            Console.WriteLine(result);
        }
    }
}