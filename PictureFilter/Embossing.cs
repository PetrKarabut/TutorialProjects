using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFilter
{
    class Embossing : MatrixFilter
    {
        public override Image TransformImage(Image picture)
        {
            double[,] matrix = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
            ApplyMatrix(picture, matrix, 3);
            return picture;
        }
    }
}
