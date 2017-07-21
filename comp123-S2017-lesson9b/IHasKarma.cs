using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: this is an interface that defines a karma property that
 * must be implmentes in any class that subscribr to it
 * version:0.1- created interface iHasKarma
 */
namespace comp123_S2017_lesson9b
{
    /// <summary>
    /// this is the IHasKarma
    /// </summary>
    public interface IHasKarma
    {
                //public properties
        int Karma { get; set; }
    }
}