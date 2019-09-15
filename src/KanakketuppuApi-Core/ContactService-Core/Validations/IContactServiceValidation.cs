using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.ContactServiceCore.Validations
{
    public interface IContactServiceValidation
    {
        List<ErrorMessage> ValidCreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}