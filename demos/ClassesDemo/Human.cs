namespace ClassesDemo
{
    internal class Human : Animal
    {
        public string FavoriteColor { get; set; } = "";
        public string MiddleName { get; set; } = "";

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


    }
}