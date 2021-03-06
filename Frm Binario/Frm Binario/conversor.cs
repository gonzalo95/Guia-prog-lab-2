using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frm_Binario
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
      return Conversor.DecimalBinario(Conversor.BinarioDecimal(b.num) - d.num);
    }

    public static implicit operator NumeroBinario(string str)
    {
      return new NumeroBinario(str);
    }

    public static explicit operator string(NumeroBinario b)
    {
      return b.num;
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
    public static double operator -(NumeroDecimal d, NumeroBinario b)
    {
      return d.num - Conversor.BinarioDecimal(b.num);
    }

    public static implicit operator NumeroDecimal(double num)
    {
      return new NumeroDecimal(num);
    }

    public static explicit operator double(NumeroDecimal d)
    {
      return d.num;
    }
  }
}
