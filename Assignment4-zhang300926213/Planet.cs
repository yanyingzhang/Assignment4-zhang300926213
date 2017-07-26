using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang - 300926213
 * Date: July 11, 2017
 * Description: COMP123 - Assignment 4
 * Version: 0.1 - Create the abstract Planet Class
 */
namespace Assignment4_zhang300926213
{
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES - 7 fields
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTITES - 7 properties
        public double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }
        
        // CONSTRUCTOR

            /// <summary>
            /// This is the constructor for the Planet class
            /// It take three parameters - name(string), diameter(double), mass(double)
            /// </summary>
            /// <param name="name"></param>
            /// <param name="diameter"></param>
            /// <param name="mass"></param>
        public Planet(string name,double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
        
        // PRIVATE METHODS

        //PUBLIC METHODS
        public override string ToString()
        {
            return string.Format("Name: " + Name + "; Diameter: " + Diameter + "; Mass: " + Mass);
        }
    }
}