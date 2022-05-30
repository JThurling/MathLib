using System.Collections;
using System.Text.RegularExpressions;

namespace Lib;

public class RealNumFunctions
{
    public static bool IsPositive<T>(T num)
    {
        if (IsNum(num))
        {
            return Comparer.Default.Compare(num, 0) > 0;
        }

        return false;
    }
    
    public static bool IsNegative<T>(T num)
    {
        
        if (IsNum(num))
        {
            return Comparer.Default.Compare(num, 0) < 0;
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
        Regex isNum = new Regex(@"^-?[0-9]\d*(\.\d+)?$");
        return isNum.Match(num.ToString()).Success;
    }
    
    public static float Absolute(float num)
    {
        if (IsNegative(num))
        {
            return -(num);
        }

        return num;
    }
    
    public static int Absolute(int num)
    {
        if (IsNegative(num))
        {
            var val = -(num);
            return -(num);
        }

        return num;
    }
    
    public static double Absolute(double num)
    {
        if (IsNegative(num))
        {
            return -(num);
        }

        return num;
    }
}