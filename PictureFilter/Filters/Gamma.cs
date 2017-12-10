using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    public class Gamma : ImageFilter
    {
        public double GammaParameter { get; set; }

        protected override Color ChangeColor(Color oldColor)
        {
            return Color.FromArgb(ChangeChannel(oldColor.R), ChangeChannel(oldColor.G), ChangeChannel(oldColor.B));
        }

        private byte ChangeChannel(byte colorComponent)
        {
            return Cut((int)Math.Round(Math.Pow(colorComponent, GammaParameter)));
        }
    }
}
