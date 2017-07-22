using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Student No. : 300901192
 * Date: July 22, 2017
 * Description: This is a TesrrestrialPlanet sub class which derived from Planet Class
 * Version: 0.3 Instance variable, Contructer, and Methods
 */
namespace Abstract_Planets
{
    //This is the TerrestrialPlanet Class
    public class TerrestrialPlanet : Planet, IHabitable,IHasMoons
    {
        //Private Instance Variable
        // This field, _oxygen, refer to the Planet if is has oxygen
        private bool _oxygen;
        
        //Constructer
        /// <summary>
        /// This this the Contructer of the Terrestrial Class
        /// It takes four aruguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }


        //Public Methods
        // This is a Boolean method that return a 
        // true value if the Planets has moon/s
        public bool HasMoons()
        {
            bool greaterThanZero = false;
            if (MoonCount > 0)
                greaterThanZero = true;
            return greaterThanZero;

        }
        //This is a boolean method that a true
        //value if the Planet is Habitable
        public bool Habitable()
        {
            bool habitable = false;
            if (_oxygen == true)
                habitable = true;
            return habitable;
          
        }



    }
}