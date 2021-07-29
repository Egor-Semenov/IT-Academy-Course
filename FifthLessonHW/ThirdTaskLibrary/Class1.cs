using System;

namespace ThirdTaskLibrary
{
    public class Cone
    {
        public double radius;
        public double high;

        public Cone(double radius, double high)
        {
            this.radius = radius;
            this.high = high;
        }

        public double BaseArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double FullArea(double radius, double high)
        {
            double l = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(high, 2));
            double baseArea = BaseArea(radius);

            return Math.PI * radius * l + baseArea;
        }
    }
}
