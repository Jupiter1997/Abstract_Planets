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
 * Version: 0.7 Create the Objects
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

            // Implement GiantPlanet by Creating a giantPlanet object
            TerrestrialPlanet terrestrialPlanet =
                new TerrestrialPlanet("Mars", 6785, 6.4e+23, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            //Wait for any Key to close console
            WaitForAnyKey();


            
        }
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }

    }
}
