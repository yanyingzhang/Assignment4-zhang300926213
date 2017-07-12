using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang - 300926213
 * Date: July 11, 2017
 * Description: COMP123 - Assignment 4
 * Version: 0.1 - Create the TerrestrialPlanet Class
 */
namespace Assignment4_zhang300926213
{
    // TerrestrialPlanet is the subclass of the Planet Abstract class
    public class TerrestrialPlanet : Planet
    {
        // PRIVATE PROPERTIES
        private bool _oxygen;

        // PUBLIC PROPERTIES

        // CONSTRACTOR
        public TerrestrialPlanet(string name,double diameter, double mass, bool oxygen)
            :base(name,diameter,mass)
        {
            this._oxygen = oxygen;
        }
        // PRIVATE METHODS

        // PUBLIC METHODS
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Habitable()
        {
            if (_oxygen == true)
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