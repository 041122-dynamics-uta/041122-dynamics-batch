using System;// this is a 'using' DIRECTIVE.
using System.Collections.Generic;

namespace collectionsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = new int[10];
            intArray[0] = -1;// because arrays are 0-indexed, 1 is the second element
            intArray[1] = -2;
            intArray[2] = -3;
            intArray[3] = -4;
            intArray[4] = -5;
            intArray[5] = -6;
            intArray[6] = -7;
            intArray[7] = -8;
            intArray[8] = -9;
            intArray[9] = -10;
            //intArray[10] = -11;//this is outide the bounds of the array


            int i = 0;
            Console.WriteLine(intArray[i]);
            for (; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }

            //a foreach loop is exactly the same as a for loop EXCEPT that 
            // it add interation built-in
            // abd stops at the end of the loop automatically.
            foreach (int mark in intArray)
            {
                Console.WriteLine(mark);
            }

            //NOW for a Generic Collection called the List
            Car c1 = new Car();
            c1.make = "Mustang";
            c1.year = 1996;

            Car c2 = new Car
            {
                make = "Lamborghini",
                year = 2021
            };

            //this is how to declare a List<>
            List<Car> carCollection0 = new List<Car>();//I'm not going to use this today...

            //this is how you declare and instantiate a list<>
            List<Car> carCollection = new List<Car>
            {
                new Car{make = "Jaguar", year=1998},//carCollection[0]
                new Car{make = "Fiat", year=1984},//carCollection[1]
                new Car{make = "Volkswagon", year=2017},//carCollection[2]
            };

            carCollection.Add(c1);//carCollection[3]
            c1.year = 3008;
            carCollection.Add(c2);//carCollection[4]

            Console.WriteLine(carCollection[3].year);
            //Console.WriteLine(c1.);//get the memory location.
            carCollection.Add(new Car { year = 1000, make = "donkey Cart" });
            Car c3 = carCollection[carCollection.Count - 1];
            Console.WriteLine($"The last car is a {c3.year} {c3.make}");

            Car c4 = carCollection.Find(x => x.year == 2017);
            Console.WriteLine($"The 2017 year ssearch resulted in a {c4.year} {c4.make}");

            //Find(x => x.year == 2017) is equivalent to the below.
            // public Car Find(int year, Car coll)
            // {
            //     foreach (Car n in coll)
            //     {
            //         if (n.year == year)
            //         {
            //             return n;
            //         }
            //     }
            // }












            // List<int> intList = new List<int>();

        }//EoM

        public class Car
        {
            public int year = 0;
            public string make = "";
        }


    }//EoC
}//EoN
