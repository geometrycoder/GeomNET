using GeomNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.GeometricPrimatives {

    public class GeometryObject : IGeometryObject {

        int id;

        public int Id {
            get { return this.id; }
        }

        public GeometryObject() {
            this.id = IdUtils.CurrentId;
        }
    }
}