using KanakketuppuApi_Core.ContactService_Core.datacontracts.externals;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Externals.Datacontracts;

namespace KanakketuppuApiCore.ContactServiceCore.Processors.Mappers
{
    public interface IContactServiceCoreProcessorMapper
    {
        ContactApiModelEx MapContactApiModelEx(ContactRequestMsgEntity contactRequestMsgEntity);
        CreateContactIPost MapCreateContactIPost(ContactApiModelEx contactApiModelEx);
    }
}