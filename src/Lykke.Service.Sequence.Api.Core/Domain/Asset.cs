using NBitcoin;

namespace Lykke.Service.Sequence.Api.Core.Domain
{
    public class Asset
    {
        public Asset(string id, int accuracy, MoneyUnit unit) => (Id, Accuracy, Unit) = (id, accuracy, unit);

        public string Id { get; }
        public int Accuracy { get; }
        public MoneyUnit Unit { get; }

        public static Asset Sequence { get; } = new Asset("SEQ", 8, MoneyUnit.BTC);
    }
}
