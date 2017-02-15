using Newtonsoft.Json.Converters;

namespace Totosinho.Infra.CrossCutting.Helper.JsonConverter
{
    public class DateJsonConverterHelper : IsoDateTimeConverter
    {
        public DateJsonConverterHelper()
        {
            this.DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
