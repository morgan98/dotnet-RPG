using System.Text.Json.Serialization;

namespace dotnet_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Infantry,
        Recon,
        Heavy,
        Medic,
        Engineer,
        Ranger,
        VeternRanger,
        Sribe,
        Paladan
    }
    
}