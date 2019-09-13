using Autofac;
using KanakketuppuApi.Mappers.ConactApi;

namespace KanakketuppuApi.Modules
{
    public class KanakketuppuApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ContactApiMapper>().As<IContactApiMapper>();
            
        }
    }
}