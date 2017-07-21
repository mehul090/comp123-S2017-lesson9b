using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: this is the super human class that extends the human abstracts class
 * version:0.4 - addedd Overridden method Tostring
 */
namespace comp123_S2017_lesson9b
{
    /// <summary>
    /// this is the super human class
    /// </summary>
    public class SuperHuman : Human
    {
        // private instance variable
        private List<Power> _powers;

        // public properties
         public List<Power> powers
        {
            get { return this._powers; }
        }
        //constructors

            /// <summary>
            /// this is the main constructor for the super human class
            /// it takes one parameter - name(string)
            /// </summary>
            /// <param name="name"></param>
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize(); 
        }

        //private methods
        /// <summary>
        /// this method initializes , instantiates and assign value to class properties
        /// </summary>
         private void _initialize()
        {
            this._powers = new List<Power>(); //create an empty list
        }

        //public methods
        /// <summary>
        /// this method add power to the power list.
        /// it take swo parametere- name, string
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// this method displays each of power in the power list
        /// </summary>
        public void DisplayPowers()
        {
            foreach( Power power in this.powers)
            {
                Console.WriteLine("power: " + power.Name + "Rank : " + power.Rank );
            }
        }
        /// <summary>
        /// overridden the build in ToString method
        /// </summary>
        /// <returns>
        /// string</returns>
        public override string ToString()
        {
            
            string outputstring = "";
            outputstring += "**********************************************\n";
            outputstring += "SuperHumsn Name: " + this.Name + " \n";
            
            outputstring += "**********************************************\n";
            foreach(Power power in this.powers)
            {
                outputstring+="Power: " + power.Name + "Rank: " + power.Rank + "\n";
            }
            outputstring += "**********************************************\n";
            return outputstring;
            
        }
    }
}