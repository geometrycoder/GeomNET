using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.GeometricPrimatives {

    public class Arc : Curve {
        
        #region members
        
        #endregion

        #region constructors
        public Arc()
            : base() {
            this.isBound = true;
        }
        #endregion

        #region properties
        
        #endregion

        #region methods
        public override Point3 Evaluate(double param, bool normaized) {
            //Evaluation: P(u) = C + r ( nx cos(u) + ny sin(u) )
            return base.Evaluate(param, normaized);
        }
        #endregion

        #region override methods

        #endregion
    }
}
