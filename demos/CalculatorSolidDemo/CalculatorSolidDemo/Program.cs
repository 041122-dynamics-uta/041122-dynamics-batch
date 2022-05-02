using System;

namespace CalculatorSolidDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ICalculator myCalc = new Calculator();

            MyCalcClass myCalcClass = new MyCalcClass(myCalc);// this is me injections the Interface variable of Calculator into MyCalcClass.

            double? result = myCalcClass.DivideSomeNumbers(1000, 100);

            Console.WriteLine($"The result of the divsion was {result}");





        }
    }
}
