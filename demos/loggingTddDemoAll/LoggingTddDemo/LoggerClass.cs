using System;
using System.IO;
using System.Xml.Serialization;
using ClassesDemo;

namespace loggingTdddemo
{
    public class LoggerClass
    {
        // Step 1. create a serializetr from the System.Xml.Serialization class
        // List<Human> hulist = new List<Human> { h1, h2, h3 };// we can declare and instantiate a list along with objects at the same time!
        // hulist.Add(h1);
        // XmlSerializer serializer1 = new XmlSerializer(hulist.GetType());
        // using (FileStream stream = File.OpenWrite("humanStorage.xml")) // this is a using block. It is different from the using declaration at the top fo the page.
        // {
        //     serializer1.Serialize(stream, hulist);
        // }

        // //File.AppendAllText("humanStorage.xml", hulist);

        // List<Human> huinlist = new List<Human>();
        // using (FileStream instream = File.OpenRead("humanStorage.xml"))
        // {
        //     hulist = (List<Human>)serializer1.Deserialize(instream);
        // }

        // foreach (Human h in huinlist)
        // {
        //     Console.WriteLine($"THe human is {h.FullName()} and it's favorite color is {h.FavoriteColor}");
        // }

        public XmlSerializer Serializer { get; set; }
        public StreamWriter OutStream { get; set; }
        public FileStream InStream { get; set; }



        /// <summary>
        /// This Constructor will initialize the serializer
        /// and the input and output streams.
        /// </summary>
        public LoggerClass()
        {
            this.Serializer = new XmlSerializer(typeof(string));
            //this.InStream = File.OpenRead("humanStorage.xml");

        }

        /// <summary>
        /// This method will take a himan and add it to the list of humans on file.
        ///
        /// </summary>
        public void AddHuman()
        {
            //
        }

        public void CreatedHuman(Human h)
        {
            this.OutStream = File.AppendText("humanStorage.xml");
            this.Serializer.Serialize(this.OutStream, $"A Human named {h.FullName()} was created at {DateTime.Now}");
            this.OutStream.Close();

        }

        internal void HumanAgeSet(Human human, int age)
        {
            this.OutStream = File.AppendText("humanStorage.xml");
            this.Serializer.Serialize(this.OutStream, $"A Human named {human.FullName()} had their age set to {age} at {DateTime.Now}.");
            this.OutStream.Close();
        }



    }
}