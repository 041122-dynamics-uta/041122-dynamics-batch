namespace ClassesDemo
{
    internal class Human : Animal, Ipilot
    {
        public string FavoriteColor { get; set; } = "";
        public string MiddleName { get; set; } = "";
        int Ipilot.PilotIdNumber { get; set; } = 0;
        DateTime Ipilot.DateOfCertification { get; set; } = DateTime.Now;
        string Ipilot.TypeOfPlane { get; set; } = "origami";

        public Human(string fname, string lname, string favColor) : base(fname, lname)
        {
            this.FavoriteColor = favColor;
        }

        public Human(string fname, string lname, string mname, string favColor) : base(fname, lname)
        {
            this.FavoriteColor = favColor;
            this.MiddleName = mname;
        }

        public void AnimalAge(int age)
        {
            this.MyAnimalAge.AnimalAge = age;
        }



        // methods section
        internal override string FullName()
        {
            string fullName = $"{this.Fname} {this.MiddleName} {this.Lname}";
            return fullName;
        }

        string Ipilot.Greeting()
        {
            //throw new NotImplementedException();
            return "Welcome to the Friendly Skies. Where a single bird means yo u end up in the Hudson. Happy Flying!";
        }

        /// <summary>
        /// This method will calculate the amount of days since the DateOfCertification adn return a sentence
        /// including the pilots name and number of says.
        /// </summary>
        /// <returns></returns>
        string Ipilot.TimeSinceCertification()
        {
            //throw new NotImplementedException();
            return "";
        }

        /// <summary>
        /// This method will take a datetime and store is at a mm/dd/yyyy DateTime.
        /// </summary>
        /// <param name="d"></param>
        internal void Ipilot.SetDateOfCertification(DateTime d)
        {
            //throw new NotImplementedException();

        }
    }
}