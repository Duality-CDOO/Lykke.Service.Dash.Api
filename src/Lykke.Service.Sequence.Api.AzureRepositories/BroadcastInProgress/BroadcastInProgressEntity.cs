using System;
using Lykke.AzureStorage.Tables;
using Lykke.AzureStorage.Tables.Entity.Annotation;
using Lykke.AzureStorage.Tables.Entity.ValueTypesMerging;
using Lykke.Service.Sequence.Api.Core.Domain.Broadcast;

namespace Lykke.Service.Sequence.Api.AzureRepositories.BroadcastInProgress
{
    [ValueTypeMergingStrategy(ValueTypeMergingStrategy.UpdateAlways)]
    internal class BroadcastInProgressEntity : AzureTableEntity, IBroadcastInProgress
    {
        public Guid OperationId
        {
            get => Guid.Parse(RowKey);
        }

        public string Hash { get; set; }
    }
}
