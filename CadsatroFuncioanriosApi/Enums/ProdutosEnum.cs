using System.Text.Json.Serialization;

namespace CadsatroFuncioanriosApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ProdutosEnum
    {
        Laptop,
        Celullar,
        PcGamer,
        Geladeira,
        Microondas,
        TvLCDPlasma
    }
}
