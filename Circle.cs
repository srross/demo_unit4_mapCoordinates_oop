using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_unit4_mapCoordinates_oop
{
    public class Circle
    {
        public double Radius { get; set; }
        public double _circumference { get; }
        // using just get behaves like using private. Makes the variable read-only.
        // how to use a properties get; set; methods instead of the constructor?
        // do the get; set; methods use the default constructor?
        // private is more descriptive of intent that using a lonesome get

        public Circle(double radius)
        {
            Radius = radius;

            // Do the logic to figure out the circumference here.
            _circumference = 2 * Math.PI * radius;
        }

        public double GetCircumference() // mehtod can be used to expose a private variable
        {
            return _circumference;
        }
    }
}
