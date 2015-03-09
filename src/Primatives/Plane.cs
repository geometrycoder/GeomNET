using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {
    
    public class Plane : GeometryObject {

        Point3 orig;
        Vector3 norm;
        Vector3 xVec;
        Vector3 yVec;

        public Plane(Point3 orig, Vector3 norm) {
            this.orig = orig;
            this.norm = norm;
            this.xVec = new Vector3(norm.U, 0, 0);
            this.yVec = new Vector3(0, norm.V, 0);
        }

        public Plane(Point3 orig, Vector3 xVec, Vector3 yVec) {
            this.orig = orig;
            this.norm = xVec.CrossProduct(yVec);
            this.xVec = xVec;
            this.yVec = yVec;
        }

        public Point3 Origin {
            get { return this.orig; }
        }

        public Vector3 Normal {
            get { return this.norm; }
        }
    }
}
