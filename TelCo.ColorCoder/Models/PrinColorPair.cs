using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder.Models
{
    public  class PrinColorPair
    {

        public static void ShowDataColors(int pairLenth)
        {
            Console.WriteLine("- - - - - - - - - - -  - - - - - -");
            Console.WriteLine("       Manual Color Reference   ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - ");
            Console.WriteLine("|{0,9}| {1,12}| {2,9}","Number", "Color Major", "Color Minor");

            Console.WriteLine(" - - - - - - - - - - - - - - - - - - -");

            int PairNumber = 1;

            do
            {
                ColorPair pair = ColorPairNumber.GetColorFromPairNumber(PairNumber);

                Console.WriteLine("|{0,9}| {1,12}| {2,9}", PairNumber, pair.majorColor.Name, pair.minorColor.Name);

                PairNumber++;

            } while (PairNumber < pairLenth);

          
            
        }
    }
}
