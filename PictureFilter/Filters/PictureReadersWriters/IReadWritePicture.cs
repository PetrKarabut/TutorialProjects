using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
   public interface IReadWritePicture
    {
        Color[,] GetMatrix(Bitmap bitmap);
        void WriteMatrixToBitmap(Color[,] matrix, Bitmap bitmap);
    }
}
