using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    public class Conversor
    {
        public static string DecimalBinario(double num)
        {
            return Convert.ToString(Convert.ToInt32(num), 2);
        }

        public static double BinarioDecimal(string bin)
        {
            return Convert.ToByte(bin, 2);
        }
    }
}