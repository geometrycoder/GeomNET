using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {
    
    public class Plane : GeometryObject {

        Point3 orig;
        Vector3 norm;
        Vector3 uVec;
        Vector3 vVec;

        public Plane(Point3 orig, Vector3 norm) {
            this.orig = orig;
            this.norm = norm;
            this.uVec = new Vector3(norm.U, 0, 0);
            this.vVec = new Vector3(0, norm.V, 0);
        }

        public Plane(Point3 orig, Vector3 uVec, Vector3 vVec) {
            this.orig = orig;
            this.norm = uVec.CrossProduct(vVec);
            this.uVec = uVec;
            this.vVec = vVec;
        }

        public Point3 Origin {
            get { return this.orig; }
        }

        public Vector3 Normal {
            get { return this.norm; }
        }
    }
}
