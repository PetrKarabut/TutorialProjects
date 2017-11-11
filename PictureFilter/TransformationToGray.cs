using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFilter
{
   public class TransformationToGray : ImageFilter
    {
        const double RedCoefficient = 0.3;
        const double GreenCoefficient = 0.59;
        const double BlueCoefficient = 0.11;

        public override void ChangePixelColor(Bitmap image, int x, int y)
        {
            Color pixel = image.GetPixel(x, y);
            image.SetPixel(x, y, GetBlackWhiteColor(pixel));
        }

        private Color GetBlackWhiteColor(Color oldColor)
        {
            double grayScale = RedCoefficient * oldColor.R + GreenCoefficient * oldColor.G + BlueCoefficient * oldColor.B;
            if (grayScale > 255)
            {
                grayScale = 255;
            }
            byte grayScaleByte = (byte)Math.Round(grayScale);
            Color newColor = Color.FromArgb(grayScaleByte, grayScaleByte, grayScaleByte);
            return newColor;
        }
    }
}
