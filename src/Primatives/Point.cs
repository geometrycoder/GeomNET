using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {

    public class Point : GeometryObject {
        
        double x, y, z;

        #region constructors
        public Point() {
            this.x = 0.0d;
            this.y = 0.0d;
            this.x = 0.0d;
        }

        public Point(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        #endregion

        #region operator overloading
        public static Point operator +(Point p, Vector v) {
            p.x += v.U;
            p.y += v.V;
            p.z += v.W;
            return p;
        }

        public static Point operator -(Point p, Vector v) {
            p.x -= v.U;
            p.y -= v.V;
            p.z -= v.W;
            return p;
        }

        public static Point operator *(Point p, Vector v) {
            p.x *= v.U;
            p.y *= v.V;
            p.z *= v.W;
            return p;
        }

        public static Point operator /(Point p, Vector v) {
            p.x /= v.U;
            p.y /= v.V;
            p.z /= v.W;
            return p;
        }
        #endregion

        #region properties
        public double X {
            get { return x; }
        }

        public double Y {
            get { return y; }
        }

        public double Z {
            get { return z; }
        }
        #endregion

        #region methods
        public double Distance (Point p) {
            return Math.Sqrt(Math.Pow(x - p.X, 2.0) + Math.Pow(y - p.Y, 2.0) + Math.Pow(z - p.Z, 2.0));
        }
        #endregion
    }
}
