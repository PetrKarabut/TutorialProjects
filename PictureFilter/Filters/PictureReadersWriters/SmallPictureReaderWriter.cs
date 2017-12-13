using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    public class SmallPictureReaderWriter : IReadWritePicture
    {
        public Color[,] GetMatrix(Bitmap bitmap)
        {
           int xSize = bitmap.Width;
           int ySize = bitmap.Height;
           var colorsArray = new Color[xSize, ySize];

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    colorsArray[x, y] = bitmap.GetPixel(x, y);
                }
            }

            return colorsArray;
        }

        public void WriteMatrixToBitmap(Color[,] matrix, Bitmap bitmap)
        {
            int xSize = matrix.GetLength(0);
            int ySize = matrix.GetLength(1);
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    bitmap.SetPixel(x, y, matrix[x, y]);
                }
            }
        }
    }
}
