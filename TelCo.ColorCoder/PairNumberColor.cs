using System;
using System.Drawing;
using TelCo.ColorCoder.Models;

namespace TelCo.ColorCoder
{
    public class PairNumberColor
    {
        public static  int GetPairNumberFromColor(ColorPair pair)
        {

            // Find the major color in the array and get the index
            int majorIndex = ColorsLoop(pair.majorColor,ColorValues.colorMapMajor);          

            // Find the minor color in the array and get the index
            int minorIndex = ColorsLoop(pair.minorColor,ColorValues.colorMapMinor);
           
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

        private static int ColorsLoop(Color pairColor, Color[] pairMapColors)
        {
            int defaultIndex = -1;

            //find Colors
            for (int i = 0; i < pairMapColors.Length; i++)
            {
                if (pairMapColors[i] == pairColor)
                {
                    defaultIndex = i;
                    break;
                }
            }

            return defaultIndex;
        }
    }
}
