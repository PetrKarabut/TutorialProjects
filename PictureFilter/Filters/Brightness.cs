using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFilter
{
    public class Brightness : ImageFilter
    {
        public int Percent { get; set; }

        protected override Color ChangeColor(Color oldColor)
        {
            return Color.FromArgb(ChangeChannel(oldColor.R), ChangeChannel(oldColor.G), ChangeChannel(oldColor.B));
        }

        private byte ChangeChannel(byte colorComponent)
        {
            return Cut(colorComponent + Percent * halfRgb / totalPercents);
        }
    }
}
