using Newtonsoft.Json.Converters;

namespace Totosinho.Infra.CrossCutting.Helper.JsonConverter
{
    public class DateJsonConverterHelper : IsoDateTimeConverter
    {
        public DateJsonConverterHelper()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}