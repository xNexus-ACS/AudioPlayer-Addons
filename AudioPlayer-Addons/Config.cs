using System.ComponentModel;
using System.IO;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace AudioPlayer_Addons
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool IsDebugging { get; set; } = false;

        [Description("EnteringFemurBreaker Audio Config")]
        public bool EnableEFB { get; set; } = true;
        public string EFBAudioPath { get; set; } = Path.Combine(Paths.Exiled, "Audio", "efb.mp3");
        [Description("Respawning Audio Config")]
        public bool EnableR { get; set; } = true;
        public string RAudioPath { get; set; } = Path.Combine(Paths.Exiled, "Audio", "respawn.mp3");
        [Description("Containing106 Audio Config")]
        public bool EnableContaining106 { get; set; } = true;
        public string Containing106AudioPath { get; set; } = Path.Combine(Paths.Exiled, "Audio", "containing.mp3");
        [Description("Dying 173, 096, 939 and 049 Audio Config")]
        public bool EnableDying { get; set; } = true;
        public string DyingAudioPath { get; set; } = Path.Combine(Paths.Exiled, "Audio", "dying.mp3");
    }
}