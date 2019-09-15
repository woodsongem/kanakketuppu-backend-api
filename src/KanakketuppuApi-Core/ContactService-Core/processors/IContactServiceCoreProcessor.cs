using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.ContactServiceCore.Processors
{
    public interface IContactServiceCoreProcessor
    {
        List<ErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}