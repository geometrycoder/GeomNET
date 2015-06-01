using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeomNET.GeometryData {

    public class Matrix<T> {

        #region members
        T[,] matrix;
        #endregion

        #region constructors
        public Matrix() {
            this.matrix = null;
        }

        public Matrix(int roxCt, int colCt) {
            this.matrix = new T[roxCt, colCt];
        }
        #endregion

        #region properties
        public T this[int row, int col] {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }
        #endregion

        #region operators

        #endregion

        #region methods

        #endregion
    }
}
