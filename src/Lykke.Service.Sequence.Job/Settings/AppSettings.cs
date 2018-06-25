using Lykke.Service.Sequence.Api.Core.Settings.SlackNotifications;

namespace Lykke.Service.Sequence.Job.Settings
{
    public class AppSettings
    {
        public SequenceJobSettings SequenceJob { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
