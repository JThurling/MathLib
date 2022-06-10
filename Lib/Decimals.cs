using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public static class Decimals
    {
        // TODO Rounding of float values
        public static dynamic Round(float value, int roundBy)
        {
            string floatString = value.ToString().Split('.')[1];
            bool v = int.TryParse(floatString[roundBy - 1].ToString(), out int val);
            bool v2 = int.TryParse(floatString[roundBy].ToString(), out int toBeRound);

            char[] charArr = floatString.ToCharArray();

            if (toBeRound >= 5)
            {
                val++;
                charArr[roundBy - 1] = char.Parse(val.ToString());
                charArr = charArr.Where((val, index) => index < roundBy).ToArray();
            }
            string s = new string(charArr);

            return float.TryParse(value.ToString().Split('.')[0] + "." + s, out float output) ? output : float.NaN;
        }


        public static dynamic Floor(float value)
        {
            string floatString = value.ToString().Split('.')[1];

            return float.TryParse($".{floatString}", out float val) ? value - val : float.NaN;
        }


        public static dynamic Ceiling(float value)
        {
            string floatString = value.ToString().Split('.')[1];

            return float.TryParse($".{floatString}", out float val) ? value + (1-val) : float.NaN;
        }
    }
}
