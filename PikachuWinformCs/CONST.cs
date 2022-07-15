using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PikachuWinformCs
{
    public class CONST
    {
        #region Properties
        private const int height = 30;
        private const int width = 30;
        private int col = 16;
        private int row = 14;
        #endregion

        #region Methods
        /// <summary>
        /// Button height
        /// </summary>
        public int Height => height;

        /// <summary>
        /// Button width
        /// </summary>
        public int Width => width;

        /// <summary>
        /// Map col
        /// </summary>
        public int Col { get => col; set => col = value; }

        /// <summary>
        /// Map row
        /// </summary>
        public int Row { get => row; set => row = value; }
        #endregion
    }
}
