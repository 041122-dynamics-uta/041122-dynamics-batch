using System;

namespace oopdemo// everything in the oopdemo folder will be in the same namespace, but separated into different files.
{
    //A class declaration is a "Blueprint" for the class instances.
    internal class Human
    {
        //private is an access modifier
        private protected string fName = "Jim";
        private protected string lName = "Halpert";

        // to encapsulate the data in the class, I create a "getter" and a "setter" method
        // the method signature is the access modifier, the return type, name of the method, 
        // and the parameters with which you call the method
        // convention says to name "TheMethodWithPascalCase".
        /// <summary>
        /// A 'virtual' method is a method that CAN be overridden
        /// using the 'override' keyword
        /// but you don't HAVE to if you don't want to.
        /// </summary>
        /// <returns></returns>
        public virtual string GetFullName()
        {
            //return this.fName + " " + this.lName;
            string fullName = $"{this.fName} {this.lName}";
            return fullName;
        }

        /// <summary>
        /// the 'abstract' keyword denotes a method that is INcomplete
        /// It does not have a body / OR  / it is incomplete
        /// </summary>
        /// <returns></returns>
       //public abstract string GetFullName1();

        /// <summary>
        /// Version 1: The parameters of this class are 2 strings.
        /// The method will assign those strings to rhe correct fields
        /// Assuming that the strings are >1 character and <20 characters.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        // public void SetFullName(string fName, string lName)// in the method the same data are called "Parameters". Giving a default value fo the parameter makes it optional.
        // {
        //     if (fName.Length > 1 && fName.Length < 20 && lName.Length > 1 && lName.Length < 20)
        //     {
        //         this.fName = fName;
        //         this.lName = lName;
        //     }
        //     else
        //     {
        //         throw new ArgumentException("The length of the names is <2 or >19");
        //     }
        // }

        /// <summary>
        /// Version 2: This method has 2 parameters wtih default values
        /// This will allow the caller to designate the value they want to insert.
        /// </summary>
        /// <param name="FName"></param>
        /// <param name="lName"></param>
        public void SetFullName(string fName = "", string lName = "")// in the method the same data are called "Parameters". Giving a default value fo the parameter makes it optional.
        {
            if (lName.Length > 1 && lName.Length < 20)
            {
                this.lName = lName;
            }
            else if (lName.Length == 0) { }
            else
            {
                throw new ArgumentException("The length of the lname is <2 or >19");
            }

            if (fName.Length > 1 && fName.Length < 20)
            {
                this.fName = fName;
            }
            else if (fName.Length == 0) { }

            else
            {
                throw new ArgumentException("The length of the fname is <2 or >19");
            }
        }

        public void SetFullName(string fName)// in the method the same data are called "Parameters". Giving a default value fo the parameter makes it optional.
        {
            if (fName.Length > 1 && fName.Length < 20)
            {
                this.fName = fName;
            }
            else
            {
                throw new ArgumentException("The length of the names is <2 or >19");
            }
        }






    }
}