using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {

    public class Vector3 : GeometryObject {

        double u, v, w;
        bool isUnit;

        #region constructors
        public Vector3() {
            this.u = 0.0d;
            this.v = 0.0d;
            this.w = 0.0d;
        }

        public Vector3(Vector3 v) {
            this.u = v.U;
            this.v = v.V;
            this.w = v.W;
        }

        public Vector3(double u, double v, double w) {
            this.u = u;
            this.v = v;
            this.w = w;
        }
        #endregion

        #region operator overloading
        public static Vector3 operator +(Vector3 v1, Vector3 v2) {
            v1.u += v2.U;
            v1.v += v2.V;
            v1.w += v2.W;
            return v1;
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2) {
            v1.u -= v2.U;
            v1.v -= v2.V;
            v1.w -= v2.W;
            return v1;
        }

        public static Vector3 operator *(Vector3 v1, Vector3 v2) {
            v1.u *= v2.U;
            v1.v *= v2.V;
            v1.w *= v2.W;
            return v1;
        }

        public static Vector3 operator /(Vector3 v1, Vector3 v2) {
            v1.u /= v2.U;
            v1.v /= v2.V;
            v1.w /= v2.W;
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
        public Vector3 CrossProduct(Vector3 v) {

        }

        public double DotProduct(Vector3 v) {

        }

        public Vector3 Negate() {

        }

        public Vector3 Normalize() {

        }

        public bool IsUnitLength() {

        }
        #endregion
    }
}
