using System;
using static System.Math;

namespace BigO_Notation.TutorialTeachers
{
    internal class MyStaticDirective
    {
        public double Radius { get; set; }

        public MyStaticDirective(double radius)
        {
            Radius = radius;
        }

        public double Diameter
        {
            get { return 2 * Radius; }
        }

        public double Cicumference
        {
            //We do not need static reference name
            get { return 2 * Radius * Math.PI; }
        }

        public double Area
        {
            get { return PI * Pow(Radius, 2); }
        }
    }
}
