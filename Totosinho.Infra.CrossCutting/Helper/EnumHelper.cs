using System.ComponentModel;

namespace Totosinho.Infra.CrossCutting.Helper
{
    public static class EnumHelper
    {
        public static string ToDescriptionString(object val)
        {
            var attributes =
                (DescriptionAttribute[])
                val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}