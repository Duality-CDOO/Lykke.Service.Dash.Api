using Lykke.Service.Sequence.Api.Core.Settings.ServiceSettings;
using Lykke.Service.Sequence.Api.Core.Settings.SlackNotifications;

namespace Lykke.Service.Sequence.Api.Core.Settings
{
    public class AppSettings
    {
        public SequenceApiSettings SequenceApiService { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
