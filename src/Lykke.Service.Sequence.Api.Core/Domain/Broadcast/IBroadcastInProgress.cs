using System;

namespace Lykke.Service.Sequence.Api.Core.Domain.Broadcast
{
    public interface IBroadcastInProgress
    {
        Guid OperationId { get; }
        string Hash { get; }
    }
}
