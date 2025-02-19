using System.Text.Json.Serialization;
using CounterStrikeSharp.API.Core;

namespace CheatESP;

public class Config : BasePluginConfig
{
    [JsonPropertyName("debug_mode")] public bool DebugMode { get; set; } = true;
    [JsonPropertyName("chat_prefix")] public string ChatPrefix { get; set; } = "{RED}[ESP]";
    [JsonPropertyName("admin_flag")] public string AdminFlag { get; set; } = "@css/root";
    [JsonPropertyName("hide_from_spectator_list")] public bool HideAdminSpectators { get; set; } = true;
    [JsonPropertyName("allow_esp_when_dead")] public bool AllowDeadAdminESP { get; set; } = true;
    [JsonPropertyName("skip_spectating_espers")] public bool SkipSpectatingEsps { get; set; } = true;

}