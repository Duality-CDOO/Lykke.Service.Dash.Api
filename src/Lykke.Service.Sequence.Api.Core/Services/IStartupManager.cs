using System.Threading.Tasks;

namespace Lykke.Service.Sequence.Api.Core.Services
{
    public interface IStartupManager
    {
        Task StartAsync();
    }
}