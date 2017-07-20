using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: demo lesson 9
 * version:0.2 - instantiated an object of type Super human
 */
 
namespace comp123_S2017_lesson9b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.powers.Add(new Power("Spider climbing", 50));
        }
    }
}
