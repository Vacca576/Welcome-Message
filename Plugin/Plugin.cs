using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.EventArgs.Player;
using System;

namespace WelcomeMessage
{
    public class WelcomeMessagePlugin : Plugin<Config>
    {
        public override string Name => "WelcomeMessage";
        public override string Author => "Vacca";
        public override string Prefix => "Welcome";
        public override Version RequiredExiledVersion => new Version(9, 0, 0);

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
            ev.Player.Broadcast(5, "Benvenuto nel server"); // Invia un messaggio di broadcast di 5 secondi
        }
    }
}
  