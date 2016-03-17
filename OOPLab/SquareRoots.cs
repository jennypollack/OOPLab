using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab
{
    class SquareRoots
    {
        public class HeronSquareRoot
        {
            private double error;
            public HeronSquareRoot(double err)
            {
                this.error = err;

            }
            public double findRoot(double n, double g)
            {
                if (n < 1) return n;
                else
                {
                    if ((g * g < n + this.error) && (g * g > n - this.error))
                    {
                        return g;
                    }
                    else return findRoot(n, (g + n / g) / 2);

                }
            }

        }

        public class SquareRoot
        {
            public SquareRoot()
            {

            }

            public double findRoot(double d)
            {
                return Math.Sqrt(d);
            }
        }
    }
}
