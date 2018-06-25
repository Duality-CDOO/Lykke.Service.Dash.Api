using System.Threading.Tasks;
using Lykke.Service.Sequence.Api.Core.Domain.InsightClient;

namespace Lykke.Service.Sequence.Api.Core.Services
{
    public interface ISequenceInsightClient
    {
        Task<decimal> GetBalance(string address, int minConfirmations);

        Task<long> GetLatestBlockHeight();

        Task<Tx> GetTx(string txid);

        Task<Tx[]> GetAddressTxs(string address, int continuation);

        Task<TxUnspent[]> GetTxsUnspentAsync(string address, int minConfirmations);

        Task<TxBroadcast> BroadcastTxAsync(string transactionHex);
    }
}
