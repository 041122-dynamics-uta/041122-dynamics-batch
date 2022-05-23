using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyBusiness;
using FamilyModels;
using FamilyRepository;

//all UI happens here.
namespace familymapping
{
    class Program
    {
        //the entrypoint for ANY C# program is the 'static void main()' method
        static async Task Main(string[] args)
        {
            FamilyRepoClass frc = new FamilyRepoClass();// to go into the constructor of the business class
            FamilyBusinessClass _fb = new FamilyBusinessClass(frc);
            Customer LoggedInCustomer = new Customer("", "", "", "");
            //present a menu to log in or to register
            Console.WriteLine("Welcome to Marks Mobile Market for the Meandering Masses!");
            int key = 0;

            do
            {
                //add the Q to quit option later.
                Console.WriteLine("Please press:\n\t1 to log in\n\t2 to register a new account.");
                string strkey = Console.ReadLine();
                key = Int32.Parse(strkey);
                Console.WriteLine("This is a spot");
            } while (key != 1 && key != 2);

            while (true)
            {
                // TODO: add logic to loop while the fname or lname is >30
                if (key == 1)
                {
                    //login prompts
                    Console.WriteLine("Please enter your username.");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Please enter your password.");
                    string password = Console.ReadLine();
                    LoggedInCustomer = await _fb.CustomerLoginAsync(userName, password);
                    if (LoggedInCustomer == null)
                    {
                        Console.WriteLine("\tThat was not a valid UserName and Password combination.\nPlease try again.\n");
                        continue;
                    }
                    else
                    {
                        //use the returned customer as the logged in customer.
                        Console.WriteLine($"\n\tWelcome, {LoggedInCustomer.Fname} {LoggedInCustomer.Lname}.\nHappy Shopping!\n");
                        break;
                    }

                }
                else if (key == 2)
                {
                    string fname, lname, userName, password;
                    do
                    {
                        Console.WriteLine("Please enter your first name.");
                        fname = Console.ReadLine();
                        Console.WriteLine("Please enter your last name.");
                        lname = Console.ReadLine();
                        if (fname.Length > 30 || lname.Length > 30)
                        {
                            Console.WriteLine("Both names must be less than 31 chacters. Please try again.");
                        }

                    } while (fname.Length > 30 || lname.Length > 30);

                    do
                    {
                        //registration prompts
                        Console.WriteLine("Please enter your username.");
                        userName = Console.ReadLine();
                        Console.WriteLine("Please enter your password.");
                        password = Console.ReadLine();
                        if (userName.Length > 30 || password.Length > 30)
                        {
                            Console.WriteLine("Both username and password must be less than 31 chacters. Please try again.");
                        }
                    } while (userName.Length > 30 || password.Length > 30);

                    //call the registration method.
                    int registerSuccess = await _fb.RegisterCustomerAsync(fname, lname, userName, password, LoggedInCustomer);
                    if (registerSuccess == 0 || registerSuccess == -1)
                    {
                        Console.WriteLine("Sorry. There is already a user with this Username and Password combination");
                        continue;
                    }
                    else
                    {
                        // call the busuness layer method to get the customer by his username and password
                        LoggedInCustomer = await _fb.CustomerLoginAsync(userName, password);
                        Console.WriteLine($"\n\tWelcome, {LoggedInCustomer.Fname} {LoggedInCustomer.Lname}.\nHappy Shopping!\n");
                        break;
                    }
                }
            }


            //
            //present the stores to the user so tht they can choose one to shop at.
            //      get all products from store.
            //


            //
            //present the products of that store
            //see past orders of this store.
            //      query Db to see all of this customers orders at this store - itemized
            //present what the user has in their cart
            //allow the user to: 
            //add a product by number
            //      "To add a product, type its id and the quantity you want separated by a space"
            //      just type the product number and quantity separated by a space to add the product
            //      the add the product and I loop to show store items (with quantites) and current cart contents.
            //delete an individual product at a time
            //      "If you would like to delete a product, type its id (only) and press enter"
            //      List the products. Ask which product they want to delete by number? element?
            //"Press Q to check out."


            //"Would you like to:
            // quit, - log them out and loop up to log in screen
            // log out,- log them out and loop up to log in screen
            // shop at a different store - stay logged in and loop up the store locations display.





            ////////////////////////////////////////////////////

            //welcome and login/register loop
            // Console.WriteLine("Hello World!");
            // //start the program here!
            // Member newMember = new Member();
            // bool moveOn = false;// this is to signify that the user correctly entered the value.
            // while (moveOn == false)
            // {
            //     Console.WriteLine("Would you like to Log in. Click 1\nWould you like to register? Click 2.");
            //     string registerOrLogin = Console.ReadLine();
            //     switch (registerOrLogin)
            //     {
            //         case "1":
            //             Console.WriteLine("Please enter your unique username");
            //             string uUsername = Console.ReadLine();
            //             Console.WriteLine("Please enter your unique password");
            //             string uPassword = Console.ReadLine();
            //             moveOn = true;
            //             break;
            //         case "2":
            //             Console.WriteLine("Please enter your first name");
            //             string fname = Console.ReadLine();
            //             Console.WriteLine("Please enter your last name");
            //             string lname = Console.ReadLine();
            //             Console.WriteLine("Please enter your age");
            //             string age = Console.ReadLine();
            //             Console.WriteLine("Please enter your familyId");
            //             string familyId = Console.ReadLine();
            //             moveOn = true;
            //             newMember = fb.NewMember(fname, lname, age, familyId);
            //             break;
            //         default:
            //             Console.WriteLine("That wasn't a valid choice. Please try again.");
            //             break;
            //     }
            // }

            // //now enter ther username and pasword into the Db as a new member
            // Console.WriteLine($"Hey, {newMember.Fname} {newMember.lname}. You are {newMember.Age} years old. fam is {newMember.FamilyId}");


            // Console.WriteLine("Would you like to see a list of all the members?");
            // string answer = Console.ReadLine();


        }
    }
}
