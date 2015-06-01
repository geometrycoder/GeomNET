using GeomNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.GeometricPrimatives {

    public class Ellipse : Curve {
        
        #region members
        Point3 center;
        double xRad;
        double yRad;
        Vector3 xAxis;
        Vector3 yAxis;
        double strParam;
        double endParam;
        #endregion

        #region constructors
        public Ellipse(Point3 center, double xRad, double yRad, Vector3 xAxis, Vector3 yAxis, double strParam, double endParam)
            : base() {
            this.isBound = true;
            this.center = center;
            this.xRad = xRad;
            this.yRad = yRad;
            this.xAxis = xAxis;
            this.yAxis = yAxis;
            this.strParam = strParam;
            this.endParam = endParam;
        }
        #endregion

        #region properties
        
        #endregion

        #region methods
        public override Point3 Evaluate(double param, bool normaized) {
            if (!normaized) {
                param = GeometryUtils.RemapValue(param, this.strParam, this.endParam, 0.0, 1.0);
            }
            //Evaluation: P(u) = C + nx rx cos(u) + ny ry sin(u)
            return this.center + (xAxis * xRad * Math.Cos(param) + yAxis + yRad + Math.Sin(param));
        }
        #endregion

        #region override methods

        #endregion
    }
}
