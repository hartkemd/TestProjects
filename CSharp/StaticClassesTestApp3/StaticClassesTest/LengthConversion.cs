using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesTest
{
    public static class LengthConversion
    {
        // not usually a good idea to store data in a static class; this lives for the duration of the application
        public static double result;

        public static void ConvertFeetToMeters(double feet)
        {
            double meters;

            meters = feet * 0.3048;

            result = meters;
        }
    }
}
