namespace CalculatorSolidDemo
{
    public class MyCalcClass
    {

        //property section
        private ICalculator _calculatorService { get; set; }

        //Constructor Section
        public MyCalcClass(ICalculator iCalculator)// Dependency Injection (DI)
        {
            this._calculatorService = iCalculator;
        }


        //method Section
        public double? DivideSomeNumbers(double a, double b)
        {
            //do some stuff with the numbers
            if (a != 0 || b != 0)
            {
                return this._calculatorService.Divide(a, b);// here we use the divide method of hte service to actually do the calculation. then return that result.
            }
            return 'x';
        }



    }
}