using System;// System is the BCL (Base Class Library)

namespace oopdemo
{
    internal class SubHuman : Human
    {
        private string middleName = "futLongie";

        public void SetFullThreeNames(string fName = "", string mName = "", string lName = "")
        {
            if (mName.Length > 1 && mName.Length < 20)
            {
                this.middleName = mName;
            }
            else if (mName.Length == 0) { }
            else
            {
                //throwing an exception is for DEVelopment ENVironment only!!!
                throw new ArgumentException("The length of the lname is <2 or >19");
            }

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

        /// <summary>
        /// This method opverriodes the abstract GetFullName1() in the base class.
        /// </summary>
        /// <returns></returns>
        // public override string GetFullName1()
        // {
        //     return "Congrats, you overrode the abstract method.";
        // }

        public override string GetFullName()
        {
            //return this.fName + " " + this.lName;
            string fullName = $"{this.fName} {this.middleName} {this.lName}";
            return fullName;
        }

    }//EoC
}//EoN