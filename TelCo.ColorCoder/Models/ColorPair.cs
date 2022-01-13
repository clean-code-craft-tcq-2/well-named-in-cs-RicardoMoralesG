using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TelCo.ColorCoder.Models;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// data type defined to hold the two colors of clor pair
    /// </summary>
    public class ColorPair
    {
        public Color majorColor;
        public Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }

    

    }
}
