using GeomNET.GeometryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Primatives {
    
    public class Curve : GeometryObject {
        #region members
        protected Point3 strPt;
        protected Point3 endPt;
        #endregion

        #region constructors
        public Curve()
            : base() {
        }
        #endregion

        #region properties
        public virtual Point3 StartPoint {
            get { return this.strPt; }
        }

        public virtual Point3 EndPoint {
            get { return this.endPt; }
        }

        public virtual double StartParameter {
            get { throw new NotImplementedException(); }
        }

        public virtual double EndParameter {
            get { throw new NotImplementedException(); }
        }
        #endregion

        #region methods
        public virtual Transform ComputeDerivatives(double param, bool normalized) {
            throw new NotImplementedException();
        }

        public virtual double ComputeNormalizedParameter(double rawParam) {
            throw new NotImplementedException();
        }

        public virtual double ComputeRawParameter(double normalizedParam) {
            throw new NotImplementedException();
        }

        public virtual double Distance(Point3 pt) {
            throw new NotImplementedException();
        }

        public virtual Point3 Evaluate(double param, bool normaized) {
            throw new NotImplementedException();
        }

        public virtual IntersectionComparisonResult Intersect(Curve curve, out List<IntersectionResult> results) {
            throw new NotImplementedException();
        }
        #endregion
    }
}
