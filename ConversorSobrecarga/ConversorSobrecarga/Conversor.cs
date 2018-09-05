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

  public class NumeroBinario
  {
    public string num;

    public NumeroBinario(string num)
    {
      this.num = num;
    }

    public static bool operator ==(NumeroBinario b, NumeroDecimal d)
    {
      return b.num == Conversor.DecimalBinario(d.num);
    }

    public static bool operator !=(NumeroBinario b, NumeroDecimal d)
    {
      return !(b == d);
    }

    public static string operator +(NumeroBinario b, NumeroDecimal d)
    {
      return Conversor.DecimalBinario(d.num + Conversor.BinarioDecimal(b.num));
    }

    public static string operator -(NumeroBinario b, NumeroDecimal d)
    {
      return Conversor.DecimalBinario(d.num - Conversor.BinarioDecimal(b.num));
    }
  }

  public class NumeroDecimal
  {
    public double num;

    public NumeroDecimal(double num)
    {
      this.num = num;
    }

    public static bool operator ==(NumeroDecimal d, NumeroBinario b)
    {
      return d.num == Conversor.BinarioDecimal(b.num);
    }

    public static bool operator !=(NumeroDecimal d, NumeroBinario b)
    {
      return !(d == b);
    }

    public static double operator +(NumeroDecimal d, NumeroBinario b)
    {
      return d.num + Conversor.BinarioDecimal(b.num);
    }
  }
}
