using System;
using System.IO;
using System.Text;

namespace Totosinho.Infra.CrossCutting.Globalizacao
{
    public static class StringExtensions
    {
        public static string ToBase64(this string str)
        {
            var strBytes = Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(strBytes);
        }

        public static string Base64ToString(this string str)
        {
            byte[] data = Convert.FromBase64String(str);
            return Encoding.UTF8.GetString(data);
        }

        public static Stream StringToStream(this string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
