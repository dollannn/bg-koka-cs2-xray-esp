using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Core;

namespace CheatESP;

public class Config : BasePluginConfig
{
    [JsonPropertyName("chat_prefix")] public string ChatPrefix { get; set; } = "{RED}[ESP]";
    [JsonPropertyName("admin_flag")] public string AdminFlag { get; set; } = "@css/root";
    [JsonPropertyName("hide_from_spectator_list")] public bool HideAdminSpectators { get; set; } = true;
}