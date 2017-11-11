using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    public class ImageFilter
    {
        const int maxRgb = 255;
        

        public virtual Image TransformImage(Image picture)
        {
            try
            {
                Bitmap image = (Bitmap)picture;

                for (int y = 0; y < image.Height; ++y)
                {
                    for (int x = 0; x < image.Width; ++x)
                    {
                        ChangePixelColor(image, x, y);
                    }
                }
                return image;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public virtual void ChangePixelColor(Bitmap image, int x, int y)
        {
            Color pixel = image.GetPixel(x, y);
            Color newColor = Color.FromArgb(maxRgb - pixel.R, maxRgb - pixel.G, maxRgb - pixel.B);
            image.SetPixel(x, y, newColor);
        }
    }
}
