using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang - 300926213
 * Date: July 11, 2017
 * Description: COMP123 - Assignment 4
 * Version: 0.1 - Create the GiantPlanet Class
 */
namespace Assignment4_zhang300926213
{
    // GiantPlanet is the subclass of the Planet Abstract class
    public class GiantPlanet : Planet
    {
        // PRIVATE PROPERTIES
        private string _type;

        // PUBLIC PROPERTIES

        // CONSTRUCTOR

            /// <summary>
            /// This is the main constractor of GiantPlanet class
            /// It takes four parameters - name(string), diameter(double), mass(double), type(string).
            /// It also takes all the parameters of the Planet base class
            /// </summary>
            /// <param name="name"></param>
            /// <param name="diameter"></param>
            /// <param name="mass"></param>
            /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name,diameter,mass)
        {
            this._type = type;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
        public bool HasMoons()
        {
            if(MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}