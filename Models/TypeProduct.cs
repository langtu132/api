using System.Text.Json.Serialization;

namespace API2.Models
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeProduct
    {
        Milk = 1,

        MilkTea = 2,

        Tea = 3
    }
}