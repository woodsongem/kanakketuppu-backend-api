using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Externals.Datacontracts;

namespace KanakketuppuApiCore.ContactServiceCore.Processors.Mappers
{
    public interface IContactServiceCoreProcessorMapper
    {
        ContactApiModelEx MapContactApiModelEx(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}