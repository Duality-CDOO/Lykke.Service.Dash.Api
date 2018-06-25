namespace Lykke.Service.Sequence.Api.Core.Settings.ServiceSettings
{
    public class SequenceApiSettings
    {
        public DbSettings Db { get; set; }
        public string Network { get; set; }
        public string InsightApiUrl { get; set; }
        public decimal Fee { get; set; }
        public int MinConfirmations { get; set; }
    }
}
