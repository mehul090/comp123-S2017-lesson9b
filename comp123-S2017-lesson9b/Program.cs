using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: demo lesson 9
 * version:0.4 - added an other power to Super human object
 * also displayed powers in power list
 */
 
namespace comp123_S2017_lesson9b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider climbing", 50);
            superHuman.AddPower("webcasting", 40);
            superHuman.DisplayPowers();
        }
    }
}
