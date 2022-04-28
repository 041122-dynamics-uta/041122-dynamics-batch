// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Serialization;
using System.IO;
using ClassesDemo;

//an argument (arg) is the data sent with a call to a method
Animal a1 = new Animal("George", "Washington", 25);

// a1 is an instance of an animal class. a1 is an object
string a1Fname = a1.Fname;

Console.WriteLine($"The animal is named {a1Fname} and it's {a1.AnimalAge()} years old.");
MyStaticClass.MarksAddress = "1234 Main st. Fort Worth TX.";

Console.WriteLine($"Marks addy is {MyStaticClass.MarksAddress}.");


Human h1 = new Human("Alexander", "Hamilton", "blue");

Console.WriteLine($"This young whipper snapper, {h1.Fname} {h1.Lname}, wants a {h1.FavoriteColor} revolution!");

Human h2 = new Human("Thomas", "Jefferson", "Raise a Glass", "Red");

Console.WriteLine($"This young whipper snapper, {h2.Fname} {h2.MiddleName} {h2.Lname}, wants a {h2.FavoriteColor} revolution!");

h2.AnimalAge(30);
Console.WriteLine($"The age of {h2.FullName()} is {h2.AnimalAge()}");

Human h3 = new Human("Sully", "Sullenberger", "Slimy Green");

h3.SetDateOfCertification(new DateTime(2000, 1, 1));

// Step 1. create a serializetr from the System.Xml.Serialization class
List<Human> hulist = new List<Human> { h1, h2, h3 };// we can declare and instantiate a list along with objects at the same time!
hulist.Add(h1);
XmlSerializer serializer1 = new XmlSerializer(hulist.GetType());
using (FileStream stream = File.OpenWrite("humanStorage.xml")) // this is a using block. It is different from the using declaration at the top fo the page.
{
    serializer1.Serialize(stream, hulist);
}

//File.AppendAllText("humanStorage.xml", hulist);

List<Human> huinlist = new List<Human>();
using (FileStream instream = File.OpenRead("humanStorage.xml"))
{
    hulist = (List<Human>)serializer1.Deserialize(instream);
}

foreach (Human h in huinlist)
{
    Console.WriteLine($"THe human is {h.FullName()} and it's favorite color is {h.FavoriteColor}");
}

/* The stack (16 gb RAM)
...is a small memory storage help physically close to the processor/
Therefore, it is fast to access. Programs you are working on are copied to the stack
any local variables you declare in your code are also on the stack IF the coding language stores them there.

When a key and value are both help on the stack, the data type is called VALUE TYPE.


/*The HEAP (ex 1Tb memory)
...is a BIG memory that is also a litttle slow. It is physicaly further away from the processor(s).
It stores you applications while you aren't using them.
In C#, and other high level coding languages, certain Types are always help on the HEAP. 
These types are called REFERENCE TYPES.
*/



// What is a value Type?
// int, char (string Type "Mark"),
string m = "Mark";// a string is held on the HEAP
Console.WriteLine(m);

bool myBool = true;// a boolean is a value type.
Console.WriteLine("Original value of mybool..." + myBool);
// myBool = false;
// Console.WriteLine(myBool);

bool c = h3.ChangeThisBool(myBool);// send mybool into the method
Console.WriteLine("Value of myBool after being changed in the method.." + myBool); // write the value of the boolean
Console.WriteLine("Value returned from the method..." + c);// write the value of the return from the method.

//now with an int!
int myInt = 111;// a boolean is a value type.
Console.WriteLine("Original value of myInt..." + myInt);
// myBool = false;
// Console.WriteLine(myBool);

myInt = h3.ChangeThisInt(myInt);// send mybool into the method
Console.WriteLine("Value of myInt after being changed in the method.." + myInt); // write the value of the boolean
Console.WriteLine("Value returned from the method..." + myInt);// write the value of the return from the method.


//take h3 and send it to ChangeThisName();
Human h4 /*0x56fba*/ = h3.ChangeThisName(h3/*0x56fba*/);
Console.WriteLine("Value of h3 after being changed in the method.." + h3.FullName()); // write the value of the boolean
Console.WriteLine("Value of h4 returned from the method..." + h4.FullName());// write the value of the return from the method.


Console.WriteLine("Fav Color of h3" + h3.FavoriteColor); // write the value of the boolean
h3.FavoriteColor = "fucia";
Console.WriteLine("Value of h4 returned from the method..." + h4.FavoriteColor);// write the value of the return from the method.


List<int> intList = new List<int> { 4, 6, 3, 8, 2, 9, 1, 90 };

intList.Sort();
foreach (int x in intList)
{
    Console.WriteLine($"x is {x}");
}

