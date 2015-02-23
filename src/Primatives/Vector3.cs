using GeomNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {

    public class Vector3 : GeometryObject {

        #region members
        double u, v, w;
        #endregion

        #region constructors
        public Vector3()
            : base() {
            this.u = 0.0d;
            this.v = 0.0d;
            this.w = 0.0d;
        }

        public Vector3(Vector3 v)
            : base() {
            this.u = v.U;
            this.v = v.V;
            this.w = v.W;
        }

        public Vector3(double u, double v, double w)
            : base() {
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

        public double Magnitude {
            get { return Math.Sqrt(Math.Pow(this.u, 2.0) + Math.Pow(this.v, 2.0) + Math.Pow(this.w, 2.0)); }
        }

        public double DirectionUV {
            get { return Math.Atan2(this.v, this.u); }
        }

        public double DirectionVW {
            get { return Math.Atan2(this.w, this.v); }
        }

        public double DirectionWU {
            get { return Math.Atan2(this.u, this.w); }
        }
        #endregion
        
        #region methods
        public Vector3 CrossProduct(Vector3 v) {
            double newU = this.v * this.w;
            double newV = this.w * this.u;
            double newW = this.u * this.v;
            return new Vector3(newU, newV, newW);
        }

        public double DotProduct(Vector3 v) {
            return this.u * v.U + this.v * v.V + this.w * v.W;
        }

        public bool IsAlmostEqualTo(Vector3 v) {
            return (GeometryUtils.DoubleComp < Math.Abs(this.u - v.U) &&
                    GeometryUtils.DoubleComp < Math.Abs(this.v - v.V) &&
                    GeometryUtils.DoubleComp < Math.Abs(this.w - v.W));
        }

        public bool IsAlmostEqualTo(Vector3 v, double tol) {
            return (tol < Math.Abs(this.u - v.U) &&
                    tol < Math.Abs(this.v - v.V) &&
                    tol < Math.Abs(this.w - v.W));
        }

        public bool IsUnitLength() {
            return GeometryUtils.DoubleComp < Math.Abs(this.Magnitude - 1.0);
        }

        public Vector3 Negate() {
            return new Vector3(-this.u, -this.v, -this.w);
        }

        public Vector3 Normalize() {
            double mag = this.Magnitude;
            double newU = this.u / mag;
            double newV = this.v / mag;
            double newW = this.w / mag;
            return new Vector3(newU, newV, newW);
        }
        #endregion

        #region override methods
        public override string ToString() {
            return String.Format("Vector 3 - {0},{1},{2}", this.u, this.v, this.w);
        }
        #endregion
    }
}
