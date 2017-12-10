using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PictureFilter
{
    public class ColorReversation : ImageFilter
    {
        protected override Color ChangeColor(Color oldColor)
        {
            return Color.FromArgb(maxRgb - oldColor.R, maxRgb - oldColor.G, maxRgb - oldColor.B);
        }

    }
}
