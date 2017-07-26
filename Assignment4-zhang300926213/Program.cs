using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Yanying Zhang - 300926213
 * Date: July 11, 2017
 * Description: COMP123 - Assignment 4
 * Version: 0.2 - Added objects to the program class
 */
namespace Assignment4_zhang300926213
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Mars",50,8000,"sun");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 60, 9000, true);
            Console.WriteLine(terrestrialPlanet.ToString());

        }
    }
}
