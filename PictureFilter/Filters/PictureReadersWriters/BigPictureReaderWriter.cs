using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace PictureFilter
{
    public class BigPictureReaderWriter : IReadWritePicture
    {
        public Color[,] GetMatrix(Bitmap bitmap)
        {
            int xSize = bitmap.Width;
            int ySize = bitmap.Height;
            var colorsArray = new Color[xSize, ySize];

            var rect = new Rectangle(0, 0, xSize, ySize);
            var bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
            var ptr = bmpData.Scan0;
            int bytes = Math.Abs(bmpData.Stride) * ySize;
            var rgbValues = new byte[bytes];
            Marshal.Copy(ptr, rgbValues, 0, bytes);

            int pixelX = 0;
            int pixelY = 0;
            for (int i = 0; i < bytes; i++)
            {
                if (i % 3 == 0 && i + 2 < bytes)
                {
                    colorsArray[pixelX, pixelY] = Color.FromArgb(rgbValues[i + 2], rgbValues[i + 1], rgbValues[i]);
                    pixelX++;
                    if (pixelX >= xSize)
                    {
                        if (pixelY < ySize - 1)
                        {
                            pixelY++;
                            pixelX = 0;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }

            bitmap.UnlockBits(bmpData);

            return colorsArray;
        }

        public void WriteMatrixToBitmap(Color[,] matrix, Bitmap bitmap)
        {
            int xSize = matrix.GetLength(0);
            int ySize = matrix.GetLength(1);

            var colors = new Color[xSize * ySize];
            int counter = 0;
            for (int y = 0; y < ySize; ++y)
            {
                for (int x = 0; x < xSize; ++x)
                {
                    colors[counter] = matrix[x, y];
                    counter++;
                }
            }

            var rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            var bmpData = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
            var ptr = bmpData.Scan0;
            int bytes = Math.Abs(bmpData.Stride) * ySize;
            var rgbValues = new byte[bytes];

            for (int i = 0; i < colors.Length; i++)
            {
                if (i * 3 + 2 >= bytes)
                {
                    break;
                }
                rgbValues[i * 3] = colors[i].B;
                rgbValues[i * 3 + 1] = colors[i].G;
                rgbValues[i * 3 + 2] = colors[i].R;
            }

            Marshal.Copy(rgbValues, 0, ptr, bytes);
            bitmap.UnlockBits(bmpData);
        }


    }
}
