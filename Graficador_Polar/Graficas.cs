using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
namespace Graficador_Polar{
    internal class Graficas{
        private double xi, xf;
        private int n;
        private double[] x;
        private double[] y;

        public Graficas(int n) {
            this.n = n;
            x = new double[n];
            y = new double[n];
        }
        public double[] X {
            set { x = value; }
            get { return x; }
        }
        public double[] Y {
            set { y = value; }
            get { return y; }
        }

        public double fu(double x, string fx){
            double r;
            ExpressionParser P1 = new ExpressionParser();
            r = Math.Cos(x);
            P1.Values.Add("x", x);
            r = P1.Parse(fx);
            return r;
        }
        public void Graficador(double xi, double xf, string fx) {
            double h;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++)
            {
                X[k] = xi + k * h;
                Y[k] = fu(X[k], fx);
            }
        }

        public void GrafPolar(double xi, double xf, string ga) {
            double h, ang, r;
            string g;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++){
                ang = xi + k * h;
                r = fu(ang, ga);
                X[k] = r * Math.Cos(ang);
                Y[k] = r * Math.Sin(ang);
            }
        }

    }
}
