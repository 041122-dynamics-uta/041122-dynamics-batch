namespace ClassesDemo
{
    // Animal is a class declaration. Animal is a BLUEPRINT for Animal Type objects. Animal Type objects are instantiations of 
    internal class Animal
    {
        //this variable is a reference variable, it is an instance of the NestedAnimal Class. It is an object.
        protected NestedAnimal MyAnimalAge { get; set; }

        // section 1 = properties and fields
        //private string fname = "Mark";
        //this is a property. It is the getter, setter and field all in one construction.
        private string fname = "";
        public string Fname
        {
            get
            {
                return this.fname;
            }
            set
            {
                if (value.Length >= 1 && value.Length < 20)
                {
                    this.fname = value;
                }
                else
                {
                    throw new InvalidDataException("That data was invalid in Classes.Animal.Fname");
                }
            }
        }

        //public string MidName { get; set; } = "Christopher";
        private string lname = "";
        public string Lname
        {
            get { return this.lname; }
            set
            {
                if (value.Length! > 1 && value.Length < 20)
                {
                    this.lname = value;
                }
                else
                {
                    throw new InvalidDataException("That data was invalid in Classes.Animal.Fname");
                }
            }
        }

        // Sections 2 = constructors
        // you are given a default no-parameter constructor
        public Animal()
        {
            this.MyAnimalAge = new NestedAnimal();
        }


        public Animal(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
            this.MyAnimalAge = new NestedAnimal();
        }

        public Animal(string fname, string lname, int animalAge)
        {
            Fname = fname;
            Lname = lname;
            this.MyAnimalAge = new NestedAnimal();
            this.MyAnimalAge.AnimalAge = animalAge;
        }


        // section 3 = Methods

        internal virtual string FullName()
        {
            string fullName = $"{this.Fname} {this.Lname}";
            return fullName;
        }

        public virtual int AnimalAge()
        {
            return this.MyAnimalAge.AnimalAge;
        }




        // Section 4 = nested Classes
        protected class NestedAnimal //this is NOT inheritance!!!!
        {
            public int AnimalAge { get; set; } = 0;

            // we are going to use the built-in Zero-Parameter constructor


            // no methods yet

        }




    }
}