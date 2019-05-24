using System;

namespace MBox.Figures
{
    public class Triangle : IFindArea
    {
        private readonly double _tolerance;
        public double A { get; }
        public double B { get; }
        public double C { get; }


        
        public bool IsRight =>
            Math.Abs(A * A - (B * B + C * C)) < _tolerance
            || Math.Abs(B * B - (A * A + C * C)) < _tolerance
            || Math.Abs(C * C - (A * A + B * B)) < _tolerance;

        public Triangle(double a, double b, double c,double tolerance=0.1)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides must be greater than 0.");

            if (!Exists(a,b,c))
                throw new ArgumentException($"Triangle with sides {a},{b},{c} doesn't exist.");
            
            _tolerance = tolerance;

            A = a;
            B = b;
            C = c;
        }

        public double FindArea()
        {
            var s = (A + B + C) / 2;
            var area = Math.Sqrt(s * (s - A) * (s - B) * (s - C));

            return area;
        }
        
        private static bool Exists(double a,double b,double c)
            => a + b > c
               && a + c > b
               && b + c > a;

        public override string ToString() => $"{A},{B},{C}";
    }
}
