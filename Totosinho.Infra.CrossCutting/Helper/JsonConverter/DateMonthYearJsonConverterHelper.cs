using Newtonsoft.Json.Converters;

namespace Totosinho.Infra.CrossCutting.Helper.JsonConverter
{
    public class DateMonthYearJsonConverterHelper : IsoDateTimeConverter
    {
        public DateMonthYearJsonConverterHelper()
        {
            base.DateTimeFormat = "MM/yyyy";
        }
    }
}
