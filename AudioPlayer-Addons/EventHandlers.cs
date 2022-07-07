using AudioPlayer.API;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace AudioPlayer_Addons
{
    public class EventHandlers
    {
        private readonly MainClass plugin;
        public EventHandlers(MainClass plugin) => this.plugin = plugin;

        public void OnEnteringFemurBreaker(EnteringFemurBreakerEventArgs ev)
        {
            if (plugin.Config.EnableEFB)
            {
                Log.Debug("[AudioPlayer-Addons: OnEnteringFemurBreaker] Audio Played!", plugin.Config.IsDebugging);
                AudioController.PlayFromFile(plugin.Config.EFBAudioPath);
            }
        }

        public void OnRespawning(RespawningTeamEventArgs ev)
        {
            if (plugin.Config.EnableR)
            {
                Log.Debug("[AudioPlayer-Addons: OnRespawning] Audio Played!", plugin.Config.IsDebugging);
                AudioController.PlayFromFile(plugin.Config.RAudioPath);
            }
        }

        public void OnContaining(ContainingEventArgs ev)
        {
            if (plugin.Config.EnableContaining106)
            {
                Log.Debug("[AudioPlayer-Addons: OnContaining] Audio Played!", plugin.Config.IsDebugging);
                AudioController.PlayFromFile(plugin.Config.Containing106AudioPath);
            }
        }

        public void OnDying(DyingEventArgs ev)
        {
            if (plugin.Config.EnableDying)
            {
                if (ev.Target.Role.Team == Team.SCP)
                {
                    Log.Debug("[AudioPlayer-Addons: OnDying] Audio Played!", plugin.Config.IsDebugging);
                    AudioController.PlayFromFile(plugin.Config.DyingAudioPath);
                }
                else return;
            }
        }
    }
}