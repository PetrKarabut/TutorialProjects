using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFilter
{
     class Contrast : Brightness
    {
        public override byte ChangeChanel(byte colorComponent)
        {
            int chanel = 0;

            if (Percent >= 0)
            {
                int div = 100 - Percent;
                if (div == 0)
                {
                    div = 1;
                }

                chanel = (colorComponent * 100 - 128 * Percent) / div;
            }
            else
            {
                chanel = (colorComponent * (100 - Percent) + 128 * Percent) / 100;
            }

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
