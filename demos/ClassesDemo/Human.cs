namespace ClassesDemo
{
    internal class Human : Animal, Ipilot
    {
        #region This is the properties region
        public string FavoriteColor { get; set; } = "";
        public string MiddleName { get; set; } = "";

        public int PilotIdNumber { get; set; } = 0;
        public DateTime DateOfCertification { get; set; } = DateTime.Now;
        public string TypeOfPlane { get; set; } = "origami";
        #endregion

        #region This is the constructors region
        public Human(string fname, string lname, string favColor) : base(fname, lname)
        {
            this.FavoriteColor = favColor;
        }

        public Human(string fname, string lname, string mname, string favColor) : base(fname, lname)
        {
            this.FavoriteColor = favColor;
            this.MiddleName = mname;
        }
        #endregion

        #region This region is for Methods

        public void AnimalAge(int age)
        {
            this.MyAnimalAge.AnimalAge = age;
        }

        internal override string FullName()
        {
            string fullName = $"{this.Fname} {this.MiddleName} {this.Lname}";
            return fullName;
        }

        //  I 'explicitely' implemented the interface methods (using 
        // their full name, i.e., Ipilot.Greeting()), therefore they could not be 
        public string Greeting()
        {
            //throw new NotImplementedException();
            return "Welcome to the Friendly Skies. Where a single bird means yo u end up in the Hudson. Happy Flying!";
        }

        /// <summary>
        /// This method will calculate the amount of days since the DateOfCertification adn return a sentence
        /// including the pilots name and number of says.
        /// </summary>
        /// <returns></returns>
        public string TimeSinceCertification()
        {
            //throw new NotImplementedException();
            return "";
        }

        /// <summary>
        /// This method will take a datetime and store is at a mm/dd/yyyy DateTime.
        /// </summary>
        /// <param name="d"></param>
        public void SetDateOfCertification(DateTime d)
        {
            //throw new NotImplementedException();
        }
        #endregion
    }
}