using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.DataContracts;

namespace KanakketuppuApiCore.ContactServiceCore.ContactService
{
    public interface IContactService
    {
        Result CreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}