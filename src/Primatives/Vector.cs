using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {

    public class Vector : GeometryElement {

        double u, v, w;

        #region constructors
        public Vector() {
            this.u = 0.0d;
            this.v = 0.0d;
            this.w = 0.0d;
        }

        public Vector(double u, double v, double w) {
            this.u = u;
            this.v = v;
            this.w = w;
        }
        #endregion

        #region operator overloading
        public static Vector operator +(Vector v1, Vector v2) {
            v1.x += v2.U;
            v1.y += v2.V;
            v1.z += v2.W;
            return v1;
        }

        public static Vector operator -(Vector v1, Vector v2) {
            v1.x -= v2.U;
            v1.y -= v2.V;
            v1.z -= v2.W;
            return v1;
        }

        public static Vector operator *(Vector v1, Vector v2) {
            v1.x *= v2.U;
            v1.y *= v2.V;
            v1.z *= v2.W;
            return v1;
        }

        public static Vector operator /(Vector v1, Vector v2) {
            v1.x /= v2.U;
            v1.y /= v2.V;
            v1.z /= v2.W;
            return v1;
        }
        #endregion

        #region properties
        public double U {
            get { return this.u;}
        }

        public double V {
            get { return this.v; }
        }

        public double W {
            get { return this.w; }
        }
        #endregion

        #region methods
        public Vector CrossProduct {

        }

        public double DotProduct {

        }
        #endregion
    }
}
