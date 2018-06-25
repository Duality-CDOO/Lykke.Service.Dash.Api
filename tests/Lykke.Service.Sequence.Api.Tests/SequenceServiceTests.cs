using Common.Log;
using Lykke.Service.Sequence.Api.Services;
using Xunit;

namespace Lykke.Service.Sequence.Api.Tests
{
    public class SequenceServiceTests
    {
        private ILog _log;

        private void Init()
        {
            _log = new LogToMemory();
        }
    }
}
