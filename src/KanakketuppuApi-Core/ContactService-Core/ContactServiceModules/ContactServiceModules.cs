using Autofac;
using KanakketuppuApiCore.ContactServiceCore.ContactService;
using KanakketuppuApiCore.ContactServiceCore.Mappers;
using KanakketuppuApiCore.ContactServiceCore.Processors;
using KanakketuppuApiCore.ContactServiceCore.Validations;

namespace KanakketuppuApiCore.ContactServiceCore.ContactServiceModules
{
    public class ContactServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder.RegisterType<ContactServiceValidation>().As<IContactServiceValidation>();
            builder.RegisterType<ContactServiceVerify>().As<IContactServiceVerify>();
            builder.RegisterType<ContactServiceMapper>().As<IContactServiceMapper>();

            builder.Register(x => new ContactOpsService(
                x.Resolve<IContactServiceValidation>(),
                x.Resolve<IContactServiceVerify>(),
                x.Resolve<IContactServiceMapper>(),
                x.Resolve<IContactServiceProcessor>()))
            .As<IContactOpsService>()
            .InstancePerLifetimeScope();
        }
    }
}