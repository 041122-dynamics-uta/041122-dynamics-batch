using System;

namespace typesExceptionsOverloadDemo
{
    //a class is stored on the HEAP (it's a REFERENCE type) and (conventionally) has methods, fields, properties, etc
    public class MarksHouse
    {
        public int year = 0;
        public string make = "";

        //overloading the constructor
        public MarksHouse() { }//parameterless constructor
        public MarksHouse(int x, string str)// parameterized constructor
        {
            this.year = x;
            this.make = str;
        }

        public int Remodel()
        {
            return ++this.year;
        }
    }

    class Program
    {
        // a struct is stored on the STACK (it's a VALUE type) and (conventionally) has only a few fields.
        // it should be very small and light.
        public struct MarksCar
        {
            public int year = 0;
            public string make = "";

            //overloading the constructor
            public MarksCar() { }//parameterless constructor
            public MarksCar(int x, string str)// parameterized constructor
            {
                this.year = x;
                this.make = str;
            }

            public int Remodel()
            {
                return ++this.year;
            }
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int num1;
            num1 = 327680;
            Console.WriteLine($"num1 GetType =>{num1.GetType()}");
            Console.WriteLine($"num1 GetTypeCode => {num1.GetTypeCode()}");
            Console.WriteLine($"num1 to ToString => {num1.ToString()}");
            Console.WriteLine($"num1 typedef to short => {((double)num1)}");

            int? num2 = null;
            Console.WriteLine($"num2 is {num2}");
            num2 = 2;
            Console.WriteLine($"num2 is {num2}");
            num2 = null;
            Console.WriteLine($"num2 is {num2}");
            Console.WriteLine($"{num2}");

            double d1 = 5.123;
            Console.WriteLine($"The double is {d1}");
            Console.WriteLine($"The int is {(int)d1}");

            Console.WriteLine("10/PI FLOAT => " + (float)(10 / Math.PI));
            Console.WriteLine("10/PI DOUBLE=> " + (double)(10 / Math.PI));

            string str1 = "Mark is the kewlest";
            ///////////////0123456789012345678 - these are the indices of our lives...
            Console.WriteLine(str1);
            Console.WriteLine(str1[12]);
            char ch1 = str1[12];
            Console.WriteLine($"This is a char! => {str1[12]}");
            Console.WriteLine(str1[0]);
            bool b1 = str1.Contains('s');
            Console.WriteLine(b1);
            bool b2 = str1.Contains(" th");
            Console.WriteLine(b2);
            string str2 = "m";
            Console.WriteLine(str2.EndsWith('m'));
            //str2 = null;
            string str3 = "";
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            string str4 = str1 + str2 + str3;
            Console.WriteLine(str4);
            str4 += str4 + str4 + str4;// the runtine allocated memory and deallocated memmory for me.
            // I didn't have to think about it.
            Console.WriteLine(str4);


            // create an instance of MarksCars struct
            MarksCar m1 = new MarksCar();
            Console.WriteLine(m1.make);
            Console.WriteLine(m1.year);

            MarksCar m2 = new MarksCar(2013, "Caravan");
            Console.WriteLine(m2.make);
            Console.WriteLine(m2.year);

            Console.WriteLine($"The year is {m1.Remodel()}");
            Console.WriteLine($"The year is {m1.Remodel()}");

            //exception handling
            // Console.WriteLine("What is your age?");
            // int str5 = Console.Read();
            // Console.WriteLine(str5);
            // string str5 = Console.ReadLine();
            // int num3 = 0;
            // try
            // {
            //     num3 = Convert.ToInt32(str5);
            // }
            // catch (OverflowException ex)// more specific exception
            // {
            //     Console.WriteLine($"The exceptions was {ex.Message}, {ex.InnerException}");
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine($"The exceptions was {ex.Message}, {ex.InnerException}");
            // }
            // catch (Exception ex)// less specific exception
            // {
            //     Console.WriteLine($"The exceptions was {ex.Message}, {ex.InnerException}");
            // }

            //a better way to handle exceptions is to write better code.

            int parsedInt = 0;
            do
            {
                Console.WriteLine("What is your age?");
                string str5 = Console.ReadLine();

                bool success1 = Int32.TryParse(str5, out parsedInt);
                // Console.WriteLine(parsedInt);
                if (success1)
                {
                    Console.WriteLine($"The paresed value of hte in is {parsedInt}");
                }

            } while (parsedInt == 0);

            Console.WriteLine(parsedInt);
            Console.WriteLine("I'm still alive!!");


        }//EoM
    }//EoC
}//EoN


// this is .NET 5.0