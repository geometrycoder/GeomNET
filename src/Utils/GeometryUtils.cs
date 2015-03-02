using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.Utils {

    public static class GeometryUtils {

        public static double DoubleComp {
            get { return -1E7; }
        }

        public static double RemapValue(double val1, double min1, double max1, double min2, double max2) {
            return (((val1 - min1) * (max2 - min2)) / (max1 - min1)) + min2;
        }
    }
}
