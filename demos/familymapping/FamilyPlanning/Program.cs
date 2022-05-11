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

            //welcome and login/register loop
            Console.WriteLine("Hello World!");
            //start the program here!
            Console.WriteLine("Would you like to see a list of all the members?");
            string answer = Console.ReadLine();


            // choose a store loop



            // on choosing a store correctly, you query the Db for the products of th at store,. 




            //fill your cart loop
            // Dictionary<Product>
            //present them with the products
            // they choose a product and the quantity the way
            // over and over
            // make don't choose more product that there are in inventory 
            // once the y choose to check out, break out of loop





            //add up the total.
            // insert the ordered products in to the Db.
            // make sure to decrement the inventory or each rproduct in the stores inventory.



            // ask if they would like to continue shopping. if yes.. loop back to the top.
            // if no, log them out and loop back to the very very tip top () login .




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
