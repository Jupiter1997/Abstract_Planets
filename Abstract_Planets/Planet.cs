using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 22, 2017
 * Description: This is the Planet super class
 * Version: 0.1 Added Constructer and a Override method
 */
namespace Abstract_Planets
{
    public abstract class Planet
    {
        //private instance variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;


        //public properties
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }
        public double Mass
        {
            get
            {
                return _mass;

            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int MoonCount
        {
            get
            {
                return _moonCount;
            }
            set
            {
                _moonCount = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }
            set
            {
                _orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return _ringCount;
            }
            set
            {
                _ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return _ringCount;
            }
            set
            {
                _rotationPeriod = value;
            }
        }
        /// <summary>
        /// This is the constructer of the super class Planet that
        /// takes 3 argument - name, diameter and mass. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        //constructer
        public Planet(string name, double diameter, double mass)        
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }

        //private methods

        //public methods
        // This is an override the inherit a ToString() Method
        // It output the Planet's Name, Diameter and Mass.
        public override string ToString()
        {
            string outputString = "";
            outputString += "Planet Name: " + Name + "\nDiameter: " +
                Diameter + "\nMass: " + Mass;
            return outputString;
        }
    }
}