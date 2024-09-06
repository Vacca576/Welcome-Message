using Exiled.API.Interfaces;
using System.ComponentModel;

namespace WelcomeMessage
{
    public class Config : IConfig
    {
        [Description("Plugin Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug Enabled?.")]
        public bool Debug { get; set; } = false;

        [Description("Message on player join.")]
        public string Message { get; set; } = "<color=lime>Welcome %player%! Please read our rules!</color>";

        [Description("Duration of Message.")]
        public ushort MessageDuration { get; set; } = 15;

    }
}
