using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    class PictureReaderWriterSelector : IReadWritePicture
    {
        private const int smallSize = 512;

        private SmallPictureReaderWriter smallPictureReaderWriter;
        private BigPictureReaderWriter bigPictureReaderWriter;

        private bool isBig(Bitmap bitmap)
        {
            return bitmap.Height * bitmap.Width > smallSize * smallSize;
        }

        public PictureReaderWriterSelector(SmallPictureReaderWriter small, BigPictureReaderWriter big)
        {
            smallPictureReaderWriter = small;
            bigPictureReaderWriter = big;
        }

        public Color[,] GetMatrix(Bitmap bitmap)
        {
            return isBig(bitmap) ? bigPictureReaderWriter.GetMatrix(bitmap) : smallPictureReaderWriter.GetMatrix(bitmap);
        }

        public void WriteMatrixToBitmap(Color[,] matrix, Bitmap bitmap)
        {
            if (isBig(bitmap))
            {
                bigPictureReaderWriter.WriteMatrixToBitmap(matrix, bitmap);
            }
            else
            {
                smallPictureReaderWriter.WriteMatrixToBitmap(matrix, bitmap);
            }
        }
    }
}
