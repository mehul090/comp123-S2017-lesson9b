using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * name: mehul khosla
 * date:july 20, 2017
 * description: demo lesson 9
 * version:0.4 - implemented super hero class
 */
 
namespace comp123_S2017_lesson9b
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("Super Dude",20);
            superHero.AddPower("teleportation", 50);
            superHero.AddPower("phasing", 40);
            superHero.AddPower("invisibility", 30);

            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);
        }
    }
}
