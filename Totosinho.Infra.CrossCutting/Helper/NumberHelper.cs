using System;

namespace Totosinho.Infra.CrossCutting.Helper
{
    public class NumberHelper
    {
        public static decimal IntegerToDecimal(object value)
        {
            return Convert.ToDecimal(value) / 100;
        }

        public static object DecimalToInteger(object value)
        {
            return Convert.ToInt32(Convert.ToDecimal(value) * 100);
        }
    }
}