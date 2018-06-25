using System.Threading.Tasks;

namespace Lykke.Service.Sequence.Job.Services
{
    public interface IPeriodicalService
    {
        Task UpdateBalances();
        Task UpdateBroadcasts();
    }
}
