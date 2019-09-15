using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.ContactServiceCore.Validations
{
    public class ContactServiceValidation : IContactServiceValidation
    {
        public List<ErrorMessage> ValidCreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}