using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;

namespace WelcomeMessage
{
    public class WelcomeMessagePlugin : Plugin<Config>
    {
        public override string Name => "WelcomeMessage";
        public override string Author => "Vacca";
        public override string Prefix => "Welcome";
        public override Version RequiredExiledVersion => new Version(8, 9, 11);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += OnPlayerVerified;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= OnPlayerVerified;
            base.OnDisabled();
        }

        private void OnPlayerVerified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(Config.MessageDuration, (Config.Broadcast));
            Log.Debug($"Messaggio di benvenuto inviato a {ev.Player.Nickname}: {Config.Broadcast}");
        }
    }
}
