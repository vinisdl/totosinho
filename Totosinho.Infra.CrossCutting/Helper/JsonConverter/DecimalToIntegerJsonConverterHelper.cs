using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Totosinho.Infra.CrossCutting.Helper.JsonConverter
{
    public class DecimalToIntegerJsonConverterHelper : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            if (reader.Value == null)
                return null;

            return NumberHelper.IntegerToDecimal(reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null) return;
            var newValue = NumberHelper.DecimalToInteger(value).ToString();
            if (newValue.Length >= 3)
                newValue = newValue.Insert(newValue.Length - 2, ".");
            JToken.FromObject(newValue).WriteTo(writer);
        }
    }
}