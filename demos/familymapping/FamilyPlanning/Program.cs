using System;
using System.Collections.Generic;
using FamilyBusiness;
using FamilyModels;
using FamilyRepository;

//all UI happens here.
namespace familymapping
{
    class Program
    {
        //the entrypoint for ANY C# program is the 'static void main()' method
        static void Main(string[] args)
        {
            FamilyRepoClass frc = new FamilyRepoClass();// to go into the constructor of the business class
            FamilyBusinessClass fb = new FamilyBusinessClass(frc);

            //welcome and login/register loop
            Console.WriteLine("Hello World!");
            //start the program here!
            Member newMember = new Member();
            bool moveOn = false;// this is to signify that the user correctly entered the value.
            while (moveOn == false)
            {
                Console.WriteLine("Would you like to Log in. Click 1\nWould you like to register? Click 2.");
                string registerOrLogin = Console.ReadLine();
                switch (registerOrLogin)
                {
                    case "1":
                        Console.WriteLine("Please enter your unique username");
                        string uUsername = Console.ReadLine();
                        Console.WriteLine("Please enter your unique password");
                        string uPassword = Console.ReadLine();
                        moveOn = true;
                        break;
                    case "2":
                        Console.WriteLine("Please enter your first name");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Please enter your last name");
                        string lname = Console.ReadLine();
                        Console.WriteLine("Please enter your age");
                        string age = Console.ReadLine();
                        Console.WriteLine("Please enter your familyId");
                        string familyId = Console.ReadLine();
                        moveOn = true;
                        newMember = fb.NewMember(fname, lname, age, familyId);
                        break;
                    default:
                        Console.WriteLine("That wasn't a valid choice. Please try again.");
                        break;
                }
            }

            //now enter ther username and pasword into the Db as a new member
            Console.WriteLine($"Hey, {newMember.Fname} {newMember.lname}. You are {newMember.Age} years old. fam is {newMember.FamilyId}");


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





            if (answer.CompareTo("yes") == 0)
            {
                // create the member class
                List<Member> members = fb.MembersList();

                foreach (Member m in members)
                {
                    Console.WriteLine($"The member is {m.Fname} {m.lname}");
                }
            }

        }
    }
}
