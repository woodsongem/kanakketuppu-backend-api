using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.ContactServiceCore.Validations
{
    public interface IContactServiceVerify
    {
        List<ErrorMessage> VerifyCreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }

}