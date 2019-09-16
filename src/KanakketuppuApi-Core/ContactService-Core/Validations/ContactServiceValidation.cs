using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.ContactServiceCore.Validations
{
    public class ContactServiceValidation : IContactServiceValidation
    {
        public List<ErrorMessage> ValidCreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            var errorMessages = IsCreateContactMsgEntityValid(contactRequestMsgEntity);
            errorMessages = IsCustomerNameValid(contactRequestMsgEntity);
            errorMessages = IsSubjectValid(contactRequestMsgEntity);
            errorMessages = IsMessageValid(contactRequestMsgEntity);
            errorMessages = IsEmailAddressValid(contactRequestMsgEntity);
            return errorMessages;
        }

        public List<ErrorMessage> IsCreateContactMsgEntityValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.CreateContactMsgEntityIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsCustomerNameValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.CustomerName.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.CustomerNameIsEmpty);

            return null;
        }

        public List<ErrorMessage> IsSubjectValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.Subject.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.SubjectIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsMessageValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.Message.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.MessageIsEmpty);
            return null;
        }

        public List<ErrorMessage> IsEmailAddressValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.EmailAddress.IsEmpty())
                return KanakketuppuUtility.GetErrorMessages(ContactServiceErrorCode.EmailAddressIsEmpty);
            return null;
        }

    }
}