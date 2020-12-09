using System;

namespace DiscriminantCounter
{
    class Discriminant
    {
        double a, b, c;
        public double D { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public Discriminant(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void countDiscriminat()
        {
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D == 0)
            {
                X1 = -b / (2 * a);
            }
            else if (D > 0)
            {
                X1 = (-b + Math.Sqrt(D)) / (2 * a);
                X2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            //else
            //{
            //    yield return "There is no real solution";
            //}
        }
    }
}
