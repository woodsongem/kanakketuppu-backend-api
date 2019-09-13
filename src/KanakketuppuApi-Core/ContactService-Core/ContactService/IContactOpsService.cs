using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.DataContracts;

namespace KanakketuppuApiCore.ContactServiceCore.ContactService
{
    public interface IContactOpsService
    {
        Result CreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}