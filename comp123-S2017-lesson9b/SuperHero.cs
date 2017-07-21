using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: this is the super hero class which inherits from the SuperHuman class
 * and implements the IHasKarma interface
 * version 0.2 - modified constructor to take Karma vlue
 */
namespace comp123_S2017_lesson9b
{
    /// <summary>
    /// this is the SuperHuman class
    /// </summary>
    public class SuperHero : SuperHuman,IHasKarma
    {
        //private instsance variable
        private int _Karma;

        //public properties
        public int Karma
        {
            get { return this._Karma; }
            set { this._Karma = value; }
        }

        /// <summary>
        /// this is the main cnstuctor for super human class
        /// it takes one argument - name
        /// </summary>
        /// <param name="name"></param>
        //constructors
        public SuperHero (string name , int Karma)
            :base(name)
        {
            this.Karma = Karma;
        }


        //private methods

        //public methods
    }
}