using GeomNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {

    public class Vector2 : GeometryObject {

        #region memebers
        double u, v;
        #endregion

        #region constructors
        public Vector2()
            : base() {
            this.u = 0.0;
            this.v = 0.0;
        }

        public Vector2(Vector2 v)
            : base() {
            this.u = v.U;
            this.v = v.V;
        }

        public Vector2(double u, double v)
            : base() {
            this.u = u;
            this.v = v;
        }
        #endregion

        #region operator overloading
        public static Vector2 operator +(Vector2 v1, Vector2 v2) {
            v1.u += v2.U;
            v1.v += v2.V;
            return v1;
        }

        public static Vector2 operator -(Vector2 v1, Vector2 v2) {
            v1.u -= v2.U;
            v1.v -= v2.V;
            return v1;
        }

        public static Vector2 operator *(Vector2 v1, Vector2 v2) {
            v1.u *= v2.U;
            v1.v *= v2.V;
            return v1;
        }

        public static Vector2 operator /(Vector2 v1, Vector2 v2) {
            v1.u /= v2.U;
            v1.v /= v2.V;
            return v1;
        }
        #endregion

        #region properties
        public double U {
            get { return this.u; }
        }

        public double V {
            get { return this.v; }
        }

        public double Magnitude {
            get { return Math.Sqrt(Math.Pow(this.u, 2.0) + Math.Pow(this.v, 2.0)); }
        }

        public double Direction {
            get { return Math.Atan2(this.v, this.u); }
        }
        #endregion

        #region methods
        public bool IsAlmostEqualTo(Vector3 v) {
            return (GeometryUtils.DoubleComp < Math.Abs(this.u - v.U) &&
                    GeometryUtils.DoubleComp < Math.Abs(this.v - v.V));
        }

        public bool IsAlmostEqualTo(Vector3 v, double tol) {
            return (tol < Math.Abs(this.u - v.U) &&
                    tol < Math.Abs(this.v - v.V));
        }
        #endregion

        #region override methods
        public override string ToString() {
            return String.Format("Vector 2 - {0},{1}", this.u, this.v);
        }
        #endregion
    }
}
