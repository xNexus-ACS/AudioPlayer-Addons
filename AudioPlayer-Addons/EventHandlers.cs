using AudioPlayer.API;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Respawning;

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
                if (ev.NextKnownTeam == SpawnableTeamType.NineTailedFox)
                {
                    AudioController.PlayFromFile(plugin.Config.RAudioPathNtf);
                }
                if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
                {
                    AudioController.PlayFromFile(plugin.Config.RAudioPathChaos);
                }
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
                if (ev.Target.Role.Type == RoleType.Scp049 || ev.Target.Role.Type == RoleType.Scp173 || ev.Target.Role.Type == RoleType.Scp096 || ev.Target.Role.Type == RoleType.Scp93953 || ev.Target.Role.Type == RoleType.Scp93989)
                {
                    Log.Debug("[AudioPlayer-Addons: OnDying] Audio Played!", plugin.Config.IsDebugging);
                    AudioController.PlayFromFile(plugin.Config.DyingAudioPath);
                }
                else return;
            }
        }
    }
}