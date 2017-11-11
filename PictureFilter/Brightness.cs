using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFilter
{
    class Brightness : ImageFilter
    {
        public int Percent { get; set; }

        public override void ChangePixelColor(Bitmap image, int x, int y)
        {
            Color pixel = image.GetPixel(x, y);
            Color newColor = Color.FromArgb(ChangeChanel(pixel.R), ChangeChanel(pixel.G), ChangeChanel(pixel.B));
            image.SetPixel(x, y, newColor);
        }

        public virtual byte ChangeChanel(byte colorComponent)
        {
            int chanel = colorComponent + Percent * 128 / 100;

            if (chanel < 0)
            {
                chanel = 0;
            }

            if (chanel > 255)
            {
                chanel = 255;
            }

            return (byte)chanel;
        }
    }
}
