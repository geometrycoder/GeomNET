using GeomNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.GeometricPrimatives {

    public class Line : Curve {

        #region members
        Point3 strPt;
        Point3 endPt;
        Vector3 dir;
        #endregion

        #region constructors
        public Line(Point3 startPoint, Point3 endPoint)
            : base() {
            this.isBound = true;
            this.strPt = startPoint;
            this.endPt = endPoint;
            this.dir = this.endPt - this.strPt;
            this.strParam = 0.0;
            this.endParam = this.strPt.DistanceTo(this.endPt);
        }

        public Line(Point3 originPoint, Vector3 direction)
            : base() {
            this.isBound = false;
            this.strPt = originPoint;
            this.endPt = null;
            this.dir = direction;
            this.strParam = Double.MinValue;
            this.endParam = Double.MaxValue;
        }
        #endregion

        #region properties
        
        #endregion

        #region methods
        public override Point3 Evaluate(double param, bool normaized) {
            if (!normaized) {
                param = GeometryUtils.RemapValue(param, this.strParam, this.endParam, 0.0, 1.0);
            }
            if (this.isBound) {
                //TODO: check for parameter bounds
                //Bound evaluation: P(u) = P1 + u (P2 - P1)                
                return this.strPt + (param * (this.dir));
            } else {
                //Unbound evaluation: P(u) = P0 + u V
                return this.strPt + param * this.dir;
            }
        }
        #endregion

        #region override methods

        #endregion
    }
}
