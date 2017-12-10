using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    public class Contrast : ImageFilter
    {
        public int Percent { get; set; }

        protected override Color ChangeColor(Color oldColor)
        {
            return Color.FromArgb(ChangeChannel(oldColor.R), ChangeChannel(oldColor.G), ChangeChannel(oldColor.B));
        }

        private  byte ChangeChannel(byte colorComponent)
        {
            if (Percent >= 0)
            {
                int div = 100 - Percent;
                if (div == 0)
                {
                    div = 1;
                }

               return Cut( (colorComponent * totalPercents - halfRgb * Percent) / div);
            }
            else
            {
                return Cut((colorComponent * (totalPercents - Percent) + halfRgb * Percent) / totalPercents);
            }
        }
    }
}
