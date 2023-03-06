using System;

namespace SomethingWithTheDelegates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class2.ResultDelegate = Class2.Calc(Class2.PowDelegate, 2, 3);
            Show(Class2.ResultDelegate);
        }

        public static void Show(Class2.ResultHandler value)
        {
            bool result = value(2);

            Console.WriteLine(result);
        }
    }
}