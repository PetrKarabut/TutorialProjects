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

        protected override Color ChangeColor(Color oldColor)
        {
            double grayScale = RedCoefficient * oldColor.R + GreenCoefficient * oldColor.G + BlueCoefficient * oldColor.B;
            if (grayScale > 255)
            {
                grayScale = 255;
            }
            byte grayScaleByte = (byte)Math.Round(grayScale);
            return Color.FromArgb(grayScaleByte, grayScaleByte, grayScaleByte);
        }

       
    }
}
