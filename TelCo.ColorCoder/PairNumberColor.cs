using System;
using System.Collections.Generic;
using System.Text;
using TelCo.ColorCoder.Models;

namespace TelCo.ColorCoder
{
    public class PairNumberColor
    {

        public static  int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < ColorValues.colorMapMajor.Length; i++)
            {
                if (ColorValues.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < ColorValues.colorMapMinor.Length; i++)
            {
                if (ColorValues.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorValues.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
