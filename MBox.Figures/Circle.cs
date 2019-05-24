using System;

namespace MBox.Figures
{
    public class Circle : IFindArea 
    {
        public double R { get; }

        public Circle(double r)
        {
            if (r <= 0)
                throw new ArgumentException("Radius must be greater than 0.");

            R = r;
        }

        public double FindArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override string ToString() => $"{R}";
    }
}
