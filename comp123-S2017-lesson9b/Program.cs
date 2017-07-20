using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: demo lesson 9
 * version:0.3 - added a power to Super human object
 */
 
namespace comp123_S2017_lesson9b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider climbing", 50);

        }
    }
}
