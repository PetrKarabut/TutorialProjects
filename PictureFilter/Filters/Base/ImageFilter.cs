using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace PictureFilter
{
    public class ImageFilter
    {
        protected const int maxRgb = 255;
        protected const int halfRgb = 128;
        protected const int totalPercents = 100;

        public IReadWritePicture PictureReaderWriter { get; set; }

        public static List<PixelFormat> GetIndexedFormats()
        {
            var indexedFormats = new List<PixelFormat> { PixelFormat.Indexed, PixelFormat.Format1bppIndexed,
                PixelFormat.Format4bppIndexed, PixelFormat.Format8bppIndexed};

            return indexedFormats;
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

                var matrix = PictureReaderWriter.GetMatrix(image);
                TransformImageArray(matrix);
                PictureReaderWriter.WriteMatrixToBitmap(matrix, image);
                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }


        // Методы TransformImageArray и ChangeColor оставлены виртуальными для того,
        // чтобы была возможность добавить фильтры, в которых получаемый цвет пикселя зависит не только
        // от самого пикселя но и от других пикселей(например размытие,акварелизация и др.).
        // В таких фильтрах метод ChangeColor не нужен(поэтому он не должен быть абстрактным),
        // вместо этого нужно переопределять метод TransformImageArray(поэтому он должен быть виртуальным).

        protected virtual void TransformImageArray(Color[,] colorsArray)
        {
            for (int x = 0; x < colorsArray.GetLength(0); x++)
            {
                for (int y = 0; y < colorsArray.GetLength(1); y++)
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

