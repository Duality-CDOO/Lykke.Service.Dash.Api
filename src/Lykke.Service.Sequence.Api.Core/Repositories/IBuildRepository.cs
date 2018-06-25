﻿using Lykke.Service.Sequence.Api.Core.Domain.Build;
using System;
using System.Threading.Tasks;

namespace Lykke.Service.Sequence.Api.Core.Repositories
{
    public interface IBuildRepository
    {
        Task<IBuild> GetAsync(Guid operationId);
        Task AddAsync(Guid operationId, string transactionContext);
        Task DeleteAsync(Guid operationId);
    }
}
