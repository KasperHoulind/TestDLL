using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDLL
{
    public class Convert1Dll
    {
        private const double Oz = 28.3495;
        private const double Grams = 0.0353;


        public static double OzToGrams(double ounces)
        {
            //Converts Ounces to Grams by multiplying with 28.3495
            return ounces * Oz;
        }


        public static double GramsToOz(double grams)
        {
            //Converts grams to Ounces by multiplying with 0.0353
            return grams * Grams;
        }
    }
}
