using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using ParallelProcessors.DataContracts;

namespace KanakketuppuApiCore.ContactServiceCore.Validations
{
    public interface IContactServiceValidation
    {
        List<ErrorMessage> ValidCreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
         List<ActionErrorMessage> IsCreateContactMsgEntityValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ActionErrorMessage> IsCustomerNameValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ActionErrorMessage> IsEmailAddressValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ActionErrorMessage> IsMessageValid(ContactRequestMsgEntity createContactMsgEntity);
        List<ActionErrorMessage> IsSubjectValid(ContactRequestMsgEntity createContactMsgEntity);
    }
}