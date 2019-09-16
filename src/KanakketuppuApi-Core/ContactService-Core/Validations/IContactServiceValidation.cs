using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.ContactServiceCore.Validations
{
    public interface IContactServiceValidation
    {
        List<ErrorMessage> ValidCreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
         List<ErrorMessage> IsCreateContactMsgEntityValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsCustomerNameValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsEmailAddressValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsMessageValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ErrorMessage> IsSubjectValid(ContactRequestMsgEntity createContactMsgEntity);
    }
}