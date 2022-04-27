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


