
using Autofac;
using ParallelProcessors.Processor;
using RestClient.Client;

namespace KanakketuppuApiCore.Utilities
{
    public class KanakketuppuApiCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ParallelProcessor>().As<IParallelProcessor>();
            builder.RegisterType<KatavuccolRestClient>().As<IKatavuccolRestClient>();
        }
    }
}