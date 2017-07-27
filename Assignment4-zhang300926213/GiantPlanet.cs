using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Yanying Zhang - 300926213
 * Date: July 11, 2017
 * Description: COMP123 - This is the GiantPlanet class
 * It is the subclass of the Planet Abstract class
 * It also implement both the IHasMoons and IHasRings interface
 * Version: 0.3 - Modified the GiantPlanet Class
 */
namespace Assignment4_zhang300926213
{
    public class GiantPlanet : Planet,IHasMoons,IHasRings
    {
        // PRIVATE PROPERTIES
        private string _type;
        private bool _hasMoon;
        private bool _hasRings;

        // PUBLIC PROPERTIES
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
        bool IHasRings.HasRings
        {
            get
            {
                return this._hasRings;
            }
            set
            {
                this._hasRings = value;
            }
        }
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