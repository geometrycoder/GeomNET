using GeomNET.GeometryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.GeometricPrimatives {
    
    public abstract class Curve : GeometryObject {

        #region member
        protected bool isBound;
        protected double strParam;
        protected double endParam;
        #endregion

        #region constructors
        public Curve()
            : base() {
            this.isBound = false;
            this.strParam = Double.MinValue;
            this.endParam = Double.MaxValue;
        }
        #endregion

        #region properties
        public bool IsBound {
            get { return this.isBound; }
        }

        public double StartParameter {
            get { return this.strParam; }
        }

        public double EndParameter {
            get { return this.endParam; }
        }

        public virtual Point3 StartPoint {
            get { return null; }
        }

        public virtual Point3 EndPoint {
            get { return null; }
        }

        public virtual double Length {
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
