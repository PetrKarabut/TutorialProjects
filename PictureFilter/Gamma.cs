using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFilter
{
     class Gamma : Brightness
    {
        public double GammaParameter { get; set; }

        public override byte ChangeChanel(byte colorComponent)
        {
            int chanel = (int)Math.Round(Math.Pow(colorComponent, GammaParameter));

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
