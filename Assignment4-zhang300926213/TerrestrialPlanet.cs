using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang - 300926213
 * Date: July 11, 2017
 * Description: COMP123 - This is the TerrestrialPlanet class 
 * It is the subclass of the Planet Abstract class
 * It also implement both the IHasMoons and IHabitable interfaces
 * Version: 0.3 - Modified the TerrestrialPlanet Class
 */
namespace Assignment4_zhang300926213
{
    public class TerrestrialPlanet : Planet,IHasMoons,IHabitable
    {
        // PRIVATE PROPERTIES
        private bool _oxygen;
        private bool _hasMoon;
        private bool _habitable;

        bool IHasMoons.HasMoons
        {
            get
            {
                return this._hasMoon;
            }
            set
            {
                this._hasMoon = value;
            }
        }
        bool IHabitable.Habitable
        {
            get
            {
                return this._habitable;
            }
            set
            {
                this._habitable = value;
            }
        }

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