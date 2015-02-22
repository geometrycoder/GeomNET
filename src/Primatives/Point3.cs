using GeomNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {

    public class Point3 : GeometryObject {
        
        double x, y, z;

        #region constructors
        public Point3() {
            this.x = 0.0d;
            this.y = 0.0d;
            this.x = 0.0d;
        }

        public Point3(Point3 p) {
            this.x = p.X;
            this.y = p.Y;
            this.z = p.Z;
        }

        public Point3(double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        #endregion

        #region operator overloading
        public static Point3 operator +(Point3 p, Vector3 v) {
            p.x += v.U;
            p.y += v.V;
            p.z += v.W;
            return p;
        }

        public static Point3 operator -(Point3 p, Vector3 v) {
            p.x -= v.U;
            p.y -= v.V;
            p.z -= v.W;
            return p;
        }

        public static Point3 operator *(Point3 p, Vector3 v) {
            p.x *= v.U;
            p.y *= v.V;
            p.z *= v.W;
            return p;
        }

        public static Point3 operator /(Point3 p, Vector3 v) {
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
        public double Distance (Point3 p) {
            return Math.Sqrt(Math.Pow(x - p.X, 2.0) + Math.Pow(y - p.Y, 2.0) + Math.Pow(z - p.Z, 2.0));
        }

        public bool IsAlmostEqualTo(Point3 p) {
            return (GeometryUtils.DoubleComp < Math.Abs(this.x - p.X) &&
                    GeometryUtils.DoubleComp < Math.Abs(this.y - p.Y) &&
                    GeometryUtils.DoubleComp < Math.Abs(this.z - p.Z));
        }

        public bool IsAlmostEqualTo(Point3 p, double tol) {
            return (tol < Math.Abs(this.x - p.X) &&
                    tol < Math.Abs(this.y - p.Y) &&
                    tol < Math.Abs(this.z - p.Z));
        }
        #endregion

        #region override methods
        public override string ToString() {
            return String.Format("Point 3 - {0},{1},{2}", this.x, this.y, this.z);
        }
        #endregion
    }
}
