using System;

namespace helloWorld2
{
    class Program
    {
        public static int num1 = 0; // num1 is a 'global' variable because it is instantiated 
        // above the entrancepoint to the program.
        static void Main(string[] args)
        {
            string howdy = "HElLo WoRlD!";
            string there1 = "I'm a string";
            Console.WriteLine($"{howdy} \tthere \npardn’r!"); //the variable is interpolated into the output.
            Console.WriteLine("{0} {1} there pardner", howdy, there1); //this syntax will insert the value of hte variable int o the correct spot in the string
            Console.WriteLine(howdy + "there" + there1 + "there pardner");// string concatenation
            Console.Write("\twhat\tis\tthe\taverage\twind\tspeed\tvelocity\tof\tan\tunladen\tswallow\n");

            //operators are + - * % ^ new 
            // &&(and) and ||(or),  ==, and!= are logical (conditional) operators. They come from boolean logic.
            //operands are integers, strings, doubles, long, (any number), floats, short
            // operator precedence is determined (essentially) by PEMDAS [BIDMAS] 
            Console.WriteLine(5 + 3); // addition
            Console.WriteLine(5 - 3); // subtract
            Console.WriteLine(5 * 3); // multiply operator
            Console.WriteLine(5 / 3); // divide... 1 the computer does not handle remainder unless you tell it to with the %
            Console.WriteLine(5 % 3); // this will give only the remainder
            Console.WriteLine(5.5 * 5); // the result will have decimals.
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Ceiling(1042.68458392948576));
            Console.WriteLine(Math.Floor(1042.68458392948576));
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(true && true);// true
            Console.WriteLine(true && false);// false
            Console.WriteLine(2 + 6 == 8 && 5 + 3 == 8); // are they both true?
            Console.WriteLine(2 + 6 == 8 && 5 + 3 == 9);
            Console.WriteLine(2 + 6 == 8 || 5 + 3 == 8); // is either true? true
            Console.WriteLine(2 + 6 == 8 || 5 + 3 == 9); // true
            Console.WriteLine(2 + 6 == 7 || 5 + 3 == 9);// false
            int gooaaaal = 5;
            Console.WriteLine(gooaaaal++);// is equivalent to 'gooaaaal = gooaaaal + 1'
            Console.WriteLine(gooaaaal + 1);
            Console.WriteLine(gooaaaal);  // 6 is printed
            Console.WriteLine(++gooaaaal);//7 is printed... when the ++ is before the variable or number, the incrementation is done before the operation.
            Console.WriteLine(gooaaaal++);// when the ++ is after the variable or number, the incrementation is done after the operation.
            Console.WriteLine(gooaaaal++);// 8
            Console.WriteLine(gooaaaal);  // 9
            Console.WriteLine(gooaaaal += 1);// 10
            Console.WriteLine(gooaaaal);

            Console.WriteLine(incTheNum());// 0
            Console.WriteLine(incTheNum());// 1
            Console.WriteLine(incTheNum());// 2
            Console.WriteLine(num1);

            if (num1 != 3)// is the statement inside the () is true, the body of the if will run.
            {
                Console.WriteLine("Num1 is not 3. YAY!");
            }
            else if (howdy.ToLowerInvariant() == "hello world!")
            {
                Console.WriteLine("The world is right again.");
                Console.WriteLine(howdy); //to show that the value of howdy has not changed.
            }
            else // else will always run IF there is no condition above it that evaluates to TRUE.
                Console.WriteLine("Num1 is 3. YAY!");

            //while and do/while
            // a while loop makes the comparison before doing the loop at all....
            while (num1 < 10)
            {
                Console.WriteLine($"The value of num1 is {num1++}");
                Math.Sqrt(100);
                Console.WriteLine(num1);
            }

            // do/while will run the body of the loop at least once.
            do
            {
                Console.WriteLine($"The value of num1 is {num1--}");
            } while (num1 > 0);
            Console.WriteLine("We just broke out of the do/while loop");

        }

        /// <summary>
        /// This method will return the current value of num1 and then 
        /// increment the value of num1.
        /// </summary>
        /// <returns></returns>
        public static int incTheNum()
        {
            return num1++;
        }

    }
}
