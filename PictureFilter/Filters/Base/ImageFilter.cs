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
    public class ImageFilter
    {
        protected const int maxRgb = 255;
        protected const int halfRgb = 128;
        protected const int totalPercents = 100;

        protected Color[,] colorsArray;
        protected int xSize;
        protected int ySize;

        private const int smallSize = 512;

        private List<PixelFormat> GetIndexedFormats()
        {
            var indexedFormats = new List<PixelFormat>();
            indexedFormats.Add(PixelFormat.Indexed);
            indexedFormats.Add(PixelFormat.Format1bppIndexed);
            indexedFormats.Add(PixelFormat.Format4bppIndexed);
            indexedFormats.Add(PixelFormat.Format8bppIndexed);
            return indexedFormats;
        }

        
        
        private Image TransformBigImage(Bitmap image)
        {
            xSize = image.Width;
            ySize = image.Height;
            colorsArray = new Color[xSize, ySize];

            // применяемый способ считывания и записи картинки основан на примере,
            // взятом отсюда: msdn.microsoft.com/ru-ru/library/system.drawing.imaging.bitmapdata(v=vs.110).aspx
            // работает значительно быстрее чем GetPixel/SetPixel

            var rect = new Rectangle(0, 0, xSize, ySize);

            var bmpData = image.LockBits(rect, ImageLockMode.ReadWrite, image.PixelFormat);

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


            TransformImageArray();

            var colors = new Color[xSize * ySize];
            int counter = 0;
            for (int y = 0; y < ySize; ++y)
            {
                for (int x = 0; x < xSize; ++x)
                {
                    colors[counter] = colorsArray[x, y];
                    counter++;
                }
            }

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
            image.UnlockBits(bmpData);
            return image;
        }

        private Image TransformSmallImage(Bitmap image)
        {
            xSize = image.Width;
            ySize = image.Height;
            colorsArray = new Color[xSize, ySize];

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    colorsArray[x, y] = image.GetPixel(x, y);
                }
            }


            TransformImageArray();

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    image.SetPixel(x, y, colorsArray[x, y]);
                }
            }

            return image;
        }

        public Image TransformImage(Image picture)
        {
            try
            {
                var image = (Bitmap)picture;

                if (GetIndexedFormats().Contains(image.PixelFormat))
                {
                    return null;
                }

                
                // для маленьких картинок(иконки и т.п.) способ с помощью BitmapData работает неправильно,
                // поэтому в этом случае используется способ с помощью SetPixel/GetPixel, который в силу малого
                // размера картинки работает быстро
                if (image.Height * image.Width >= smallSize * smallSize)
                {
                    return TransformBigImage(image);
                }
                else
                {
                    return TransformSmallImage(image);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected virtual void TransformImageArray()
        {
            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    colorsArray[x, y] = ChangeColor(colorsArray[x, y]);
                }
            }
        }

        protected virtual Color ChangeColor(Color oldColor)
        {
            return oldColor;
        }

        protected byte Cut(int old)
        {
            if (old > maxRgb)
            {
                return maxRgb;
            }
            else if (old < 0)
            {
                return 0;
            }
            else
            {
                return (byte)old;
            }
        }
    }
}

