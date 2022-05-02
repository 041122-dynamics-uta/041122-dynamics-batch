namespace CalculatorSolidDemo
{
    public class Calculator : ICalculator
    {

        /// <summary>
        /// The method adds y to x and returns the sum as a double.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Add(double x, double y)
        {
            double z = x + y;
            return z;
        }

        /// <summary>
        /// The method divides x by y and returns the quotient as a double.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Divide(double x, double y)
        {
            double z = x / y;
            return z;
        }

        /// <summary>
        /// The method multiplies y and x and returns the product as a double.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }

        /// <summary>
        /// The method subtracts y from x and returns the difference as a double.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Subtract(double x, double y)
        {
            double z = x - y;
            return z;
        }


        public string TellMeToStop()
        {
            return "STOP!";
        }
    }
}