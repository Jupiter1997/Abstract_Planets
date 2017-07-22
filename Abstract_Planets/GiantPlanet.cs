using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 22, 2017
 * Description: This is a Giant Planet sub class which derived from Planet Class
 * Version: 0.2 Instance variable, Contructer, and Methods
 */
namespace Abstract_Planets
{
    // This is the Giant Sub clas
    public class GiantPlanet : Planet
    {
        
        //Private Instance Varibles
        //This field, _type, refers to what type of GiantPlanet it is
        private string _type;

        /// <summary>
        /// This is the contructer of the the Giant Planet
        /// It take four arguments.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        //Contructer
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name, diameter,mass)
        {
            this._type = type;
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
        // This is a Boolean method that return a 
        // true value if the Planets has rings/s
        public bool HasRings()
        {
            bool greaterThanZero = false;
            if (RingCount > 0)
                greaterThanZero = true;
            return greaterThanZero;

        }

    }
}