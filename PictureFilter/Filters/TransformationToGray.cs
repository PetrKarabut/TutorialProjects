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
        private const double RedCoefficient = 0.3;
        private const double GreenCoefficient = 0.59;
        private const double BlueCoefficient = 0.11;

        protected override Color ChangeColor(Color oldColor)
        {
            double grayScale = RedCoefficient * oldColor.R + GreenCoefficient * oldColor.G + BlueCoefficient * oldColor.B;
            if (grayScale > maxRgb)
            {
                grayScale = maxRgb;
            }
            byte grayScaleByte = (byte)Math.Round(grayScale);
            return Color.FromArgb(grayScaleByte, grayScaleByte, grayScaleByte);
        }

       
    }
}
