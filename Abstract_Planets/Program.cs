using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Marvin Jupiter Vargas
 * Student No. : 300901192
 * Date: July 22, 2017
 * Description: Creating the Giant and Terrestial Object to test Program
 * Version: 0.8 added moon habitable and ring statements.
 */
namespace Abstract_Planets
{
    class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            // Implement GiantPlanet by Creating a giantPlanet object
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 142800, 1.898e+27, "Gas"); 
            Console.WriteLine(giantPlanet.ToString());
            int moonCount = 69, ringCount = 4;
            giantPlanet.MoonCount = moonCount; giantPlanet.RingCount = ringCount; // set moon and ring count
            Console.WriteLine("{0}", giantPlanet.HasMoons() ? "This planet have moons :" + moonCount : "This planet dont have moons");
            Console.WriteLine("{0}", giantPlanet.HasRings() ? "This planet have rings :" + ringCount : "This planet dont have rings");
           
            // Implement GiantPlanet by Creating a giantPlanet object
            TerrestrialPlanet terrestrialPlanet =
                new TerrestrialPlanet("Mars", 6785, 6.4e+23, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            moonCount = 0;
            terrestrialPlanet.MoonCount = moonCount; 
            Console.WriteLine("{0}", terrestrialPlanet.Habitable() ? "This planet have Oxygen, is habitable" : "This planet is not habitable");
            Console.WriteLine("{0}", terrestrialPlanet.HasMoons() ? "This planet have moons" : "This planet dont have moons");

            //Wait for any Key to close console
            WaitForAnyKey();


            
        }
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }

    }
}
