using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Marvin Jupiter Vargas
 * Date: July 22, 2017
 * Description: This is the Planet super class
 * Version: 0.1 Planet class created with fields and properties
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
        private double _rotatiobPeriod;


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
                _rotatiobPeriod = value;
            }
        }
        //constructer

        //private methods

        //public methods
    }
}