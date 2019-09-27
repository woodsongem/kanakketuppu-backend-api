using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using KanakketuppuApiCore.DataContracts;

namespace KanakketuppuApiCore.ContactServiceCore.ContactService
{
    public interface IContactOpsService
    {
        List<ErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}