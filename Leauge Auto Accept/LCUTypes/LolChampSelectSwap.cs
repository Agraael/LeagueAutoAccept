using System.Text.Json.Serialization;

namespace Leauge_Auto_Accept.LCUTypes
{
    public record LolChampSelectSwap(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("initiatedByLocalPlayer")] bool InitiatedByLocalPlayer
    );
}
