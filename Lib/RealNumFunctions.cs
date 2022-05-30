using System.Collections;
using System.Text.RegularExpressions;

namespace Lib;

internal class RealNumFunctions
{
    public static bool IsPositive<T>(T type)
    {
        string num = type.ToString();
        if (IsNum(type))
        {
            var value = ReturnNumValue(num, typeof(T));
            return Comparer.Default.Compare(value, 0) < 0;
        }

        return false;
    }

    private static object ReturnNumValue(string? num, Type type)
    {
        if (type.GetType() is int)
        {
            return Int32.Parse(num);
        }

        if (type.GetType() is float)
        {
            return float.Parse(num);
        }

        return 0;
    }

    private static bool IsNum(object num)
    {
        Regex isNum = new Regex("^[0-9]+$");
        return isNum.Match((string) num).Success;
    }
}