using System;
using System.Collections.Generic;
using System.Text;

namespace TelCo.ColorCoder.Models
{
    public  class PrinColorPair
    {

        public static int ShowDataColors(int pairLenth)
        {
            Console.WriteLine("- - - - - - - - - - -  - - - - - -");
            Console.WriteLine("       Manual Color Reference   ");
            Console.WriteLine("- - - - - - - - - - - - - - - - - ");
            Console.WriteLine("|{0,9}| {1,12}| {2,9}","Number", "Color Major", "Color Minor");

            Console.WriteLine(" - - - - - - - - - - - - - - - - - - -");

            int PairNumber = 0;

            do
            {
                PairNumber++;

                ColorPair pair = ColorPairNumber.GetColorFromPairNumber(PairNumber);

                Console.WriteLine("|{0,9}| {1,12}| {2,9}", PairNumber, pair.majorColor.Name, pair.minorColor.Name);

               
            } while (PairNumber < pairLenth);


            return PairNumber;
        }
    }
}
