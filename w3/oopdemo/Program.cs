using System;

namespace oopdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //data exposed to the world
            string marksName = "Mark Moore";
            Console.WriteLine($"\nThe name of ya boy is {marksName}.\n");

            Human jimHalpert = new Human();
            //Console.WriteLine($"\nThe name of ya (abstracted away) brah is {jimHalpert.fName} {jimHalpert.lName}.\n");
            // jimHalpert.fName = "Dwight K";
            // jimHalpert.lName = "Schrughte";

            //Console.WriteLine($"\nThe name of ya (abstracted away and modified) brah is {jimHalpert.fName} {jimHalpert.lName}.\n");

            string fullName = jimHalpert.GetFullName();
            Console.WriteLine($"Jims fullname is {fullName}.");
            Console.WriteLine("Now we will change Jims name through the setter method.");
            jimHalpert.SetFullName("Andy");//when calling a method, you send "Arguments"
            Console.WriteLine($"The name now is {jimHalpert.GetFullName()}");


            jimHalpert.SetFullName("Halpert");//when calling a method, you send "Arguments"
            Console.WriteLine($"The name now is {jimHalpert.GetFullName()}");

            jimHalpert.SetFullName(lName: "Mark", fName: "Moore");
            Console.WriteLine($"The name now is {jimHalpert.GetFullName()}");

            jimHalpert.SetFullName(lName: "Moore", fName: "MarkMarkMarrkMarkm");
            Console.WriteLine($"The name now is {jimHalpert.GetFullName()}");


            // Now I'll create a SubHuman tht inherits from Human. 
            // It has allt he same characteristics.
            SubHuman sh1 = new SubHuman();
            sh1.SetFullThreeNames("Ryan", "Swanson", "Howard");
            Console.WriteLine($"The subhuman is named {sh1.GetFullName()}");




            //Console.WriteLine($"The full name with the middle name is {sh1.GetFullName()}.");




        }
    }
}
