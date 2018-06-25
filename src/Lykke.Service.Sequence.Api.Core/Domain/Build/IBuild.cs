using System;

namespace Lykke.Service.Sequence.Api.Core.Domain.Build
{
    public interface IBuild
    {
        Guid OperationId { get; }
        string TransactionContext { get; }
    }
}
