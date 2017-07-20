using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: this is the super human class that extends the human abstracts class
 * version:0.2 - addedd _initialize method
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
    }
}