using Autofac;
using Common.Log;
using Lykke.Service.Sequence.Api.AzureRepositories.BroadcastInProgress;
using Lykke.Service.Sequence.Api.Core.Services;
using Lykke.Service.Sequence.Api.Core.Repositories;
using Lykke.Service.Sequence.Api.Core.Settings.ServiceSettings;
using Lykke.Service.Sequence.Api.Services;
using Lykke.SettingsReader;
using Lykke.Service.Sequence.Api.AzureRepositories.Balance;
using Lykke.Service.Sequence.Api.AzureRepositories.BalancePositive;
using Lykke.Service.Sequence.Api.AzureRepositories.Broadcast;
using Lykke.Service.Sequence.Api.AzureRepositories.Build;

namespace Lykke.Service.Sequence.Api.Modules
{
    public class ServiceModule : Module
    {
        private readonly IReloadingManager<SequenceApiSettings> _settings;
        private readonly ILog _log;

        public ServiceModule(IReloadingManager<SequenceApiSettings> settings, ILog log)
        {
            _settings = settings;
            _log = log;
        }

        protected override void Load(ContainerBuilder builder)
        {
            var connectionStringManager = _settings.ConnectionString(x => x.Db.DataConnString);

            builder.RegisterInstance(_log)
                .As<ILog>()
                .SingleInstance();

            builder.RegisterType<HealthService>()
                .As<IHealthService>()
                .SingleInstance();

            builder.RegisterType<StartupManager>()
                .As<IStartupManager>();

            builder.RegisterType<ShutdownManager>()
                .As<IShutdownManager>();

            builder.RegisterType<BroadcastRepository>()
                .As<IBroadcastRepository>()
                .WithParameter(TypedParameter.From(connectionStringManager))
                .SingleInstance();

            builder.RegisterType<BroadcastInProgressRepository>()
                .As<IBroadcastInProgressRepository>()
                .WithParameter(TypedParameter.From(connectionStringManager))
                .SingleInstance();

            builder.RegisterType<BalanceRepository>()
                .As<IBalanceRepository>()
                .WithParameter(TypedParameter.From(connectionStringManager))
                .SingleInstance();

            builder.RegisterType<BalancePositiveRepository>()
                .As<IBalancePositiveRepository>()
                .WithParameter(TypedParameter.From(connectionStringManager))
                .SingleInstance();

            builder.RegisterType<BuildRepository>()
                .As<IBuildRepository>()
                .WithParameter(TypedParameter.From(connectionStringManager))
                .SingleInstance();

            builder.RegisterType<SequenceInsightClient>()
                .As<ISequenceInsightClient>()
                .WithParameter("url", _settings.CurrentValue.InsightApiUrl)
                .SingleInstance();

            builder.RegisterType<SequenceService>()
                .As<ISequenceService>()
                .WithParameter("network", _settings.CurrentValue.Network)
                .WithParameter("fee", _settings.CurrentValue.Fee)
                .WithParameter("minConfirmations", _settings.CurrentValue.MinConfirmations)
                .SingleInstance();
        }
    }
}
