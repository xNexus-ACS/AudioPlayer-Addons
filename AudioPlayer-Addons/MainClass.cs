using System;
using Exiled.API.Features;
using PlayerHandler = Exiled.Events.Handlers.Player;
using ServerHandler = Exiled.Events.Handlers.Server;
using Scp106Handler = Exiled.Events.Handlers.Scp106;

namespace AudioPlayer_Addons
{
    public class MainClass : Plugin<Config>
    {
        public override string Author { get; } = "xNexusACS";
        public override string Name { get; } = "AudioPlayer Addons";
        public override string Prefix { get; } = "audioplayer_addons";
        public override Version Version { get; } = new Version(0, 1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 2);
        
        public EventHandlers EventHandlers { get; private set; }
        
        public override void OnEnabled()
        {
            EventHandlers = new EventHandlers(this);
            
            PlayerHandler.EnteringFemurBreaker += EventHandlers.OnEnteringFemurBreaker;
            ServerHandler.RespawningTeam += EventHandlers.OnRespawning;
            Scp106Handler.Containing += EventHandlers.OnContaining;
            PlayerHandler.Dying += EventHandlers.OnDying;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            PlayerHandler.EnteringFemurBreaker -= EventHandlers.OnEnteringFemurBreaker;
            ServerHandler.RespawningTeam -= EventHandlers.OnRespawning;
            Scp106Handler.Containing -= EventHandlers.OnContaining;
            PlayerHandler.Dying -= EventHandlers.OnDying;
            
            EventHandlers = null;
            base.OnDisabled();
        }
    }
}