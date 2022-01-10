using System;
using System.Collections.Generic;
using System.Text;
using TelCo.ColorCoder.Models;

namespace TelCo.ColorCoder
{
    public class ColorPairNumber
    {

        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorLength = ColorValues.colorMapMinor.Length;
            int majorLength = ColorValues.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorLength * majorLength)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorLength;
            int minorIndex = zeroBasedPairNumber % majorLength;

            // Construct the return val from the arrays
            ColorPair pair = new ColorPair()
            {
                majorColor = ColorValues.colorMapMajor[majorIndex],
                minorColor = ColorValues.colorMapMinor[minorIndex]
            };

            // return the value
            return pair;
        }
    }
}
