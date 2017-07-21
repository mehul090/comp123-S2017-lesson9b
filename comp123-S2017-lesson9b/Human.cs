using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: this is the abstract human class
 * version:0.2 - created public abstract meethod
 */
namespace comp123_S2017_lesson9b
{
    /// <summary>
    /// this is the abstract Human class
    /// </summary>
    public abstract class Human
    {
        //private instance variable (fields)
        private string _name;


        //public properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }


        //constructors------------------------
        /// <summary>
        /// this is the main constructor for the human class
        /// it takes on parameter - name(string)
        /// </summary>
        /// <param name="name"></param>


        public Human(string name)
        {
            this.Name = name;
        }

        // public absract metods
        public abstract void DisplaySkills();


       
    }
}

