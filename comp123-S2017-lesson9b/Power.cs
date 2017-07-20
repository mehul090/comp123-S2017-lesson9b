using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: demo for lesson 9
 * version:0.2 - added constructor
 */
namespace comp123_S2017_lesson9b
{
    /// <summary>
    /// this is the power class class which will be used as a datatype
    /// </summary>
    public class Power
    {
        //public properties
        public string Name { get; set; }
        public int Rank { get; set; }

        //constructor----------------------
        /// <summary>
        /// this is the main constructor for the power class
        /// it take two arguments - name, rank
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

    }
}