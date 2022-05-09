using System;
using System.Collections.Generic;
using FamilyBusiness;
using FamilyModels;
using FamilyRepository;

namespace familymapping
{
    class Program
    {
        //the entrypoint for ANY C# program is the 'static void main()' method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //start the program here!
            Console.WriteLine("Would you like to see a list of all the members?");
            string answer = Console.ReadLine();


            FamilyRepoClass frc = new FamilyRepoClass();

            FamilyBusinessClass fb = new FamilyBusinessClass(frc);

            if (answer.CompareTo("yes") == 0)
            {
                // create the member class
                List<Member> members = fb.MembersList();

                foreach (Member m in members)
                {
                    Console.WriteLine($"The members data is Fname-{m.Fname}.....");
                }

            }

        }
    }
}
