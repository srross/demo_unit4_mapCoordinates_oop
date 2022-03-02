using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_unit4_mapCoordinates_oop
{
    public class Point
    {
        private const double _x = 0;
        private const double _y = 0;

        private double[] _pt1 = new double[2];
        private double[] _pt2 = new double[2];

        private double _x2 { get; set; }
        private double _y2 { get; set; }

        private double _distance { get; set; }
        private double _midpoint { get; set; }

        public Point(double x2, double y2, double[] pt = null)
        {
            _x2 = x2;
            _y2 = y2;
        }

        public string MapPointObject()
        {
            _pt2[0] = _x2; // this pt
            _pt2[1] = _y2; // this pt

            var message = $"You have created a double object ({_pt2[0]},{_pt2[1]})";

            return message;
        }

        public string CalculateDistance()
        {
            _distance = Convert.ToDouble(Math.Sqrt((Math.Pow(_x2 - _x, 2) + Math.Pow(_y2 - _y, 2))));


            var message = $"It has a distance of {_distance}";
           
            return message;
        }

        public string CalculateMidpoint(double[] pt2)
        {
            _midpoint = 0.0; // figure out calculation here

            var message = $"The midpodouble between {pt2[0]} and {pt2[1]} is { _midpoint}"; // This is not right.  figure out for both points

            return message;
        }
    }
}