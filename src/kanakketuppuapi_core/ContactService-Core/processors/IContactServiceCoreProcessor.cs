using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using ParallelProcessors.DataContracts;

namespace KanakketuppuApiCore.ContactServiceCore.Processors
{
    public interface IContactServiceCoreProcessor
    {
        List<ActionErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}