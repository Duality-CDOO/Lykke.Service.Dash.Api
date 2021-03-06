﻿using System;
using Lykke.AzureStorage.Tables;
using Lykke.AzureStorage.Tables.Entity.Annotation;
using Lykke.AzureStorage.Tables.Entity.ValueTypesMerging;
using Lykke.Service.Sequence.Api.Core.Domain.Build;

namespace Lykke.Service.Sequence.Api.AzureRepositories.Build
{
    [ValueTypeMergingStrategy(ValueTypeMergingStrategy.UpdateAlways)]
    internal class BuildEntity : AzureTableEntity, IBuild
    {
        public Guid OperationId
        {
            get => Guid.Parse(RowKey);
        }

        public string TransactionContext { get; set; }
    }
}
