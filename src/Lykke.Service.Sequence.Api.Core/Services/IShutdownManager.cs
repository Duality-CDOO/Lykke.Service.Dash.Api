using System.Threading.Tasks;

namespace Lykke.Service.Sequence.Api.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}