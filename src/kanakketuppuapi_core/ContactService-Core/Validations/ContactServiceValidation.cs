using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.ContactServiceCoreUtilities;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using KanakketuppuApiCore.Utilities;
using KatavuccolCommon.Extensions;
using ParallelProcessors.DataContracts;
using ParallelProcessors.Processor;

namespace KanakketuppuApiCore.ContactServiceCore.Validations
{
    public class ContactServiceValidation : IContactServiceValidation
    {
        private readonly IParallelProcessor parallelProcessor;
        public ContactServiceValidation(IParallelProcessor parallelProcessor)
        {
            this.parallelProcessor = parallelProcessor;
        }

        public List<ErrorMessage> ValidCreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            var parallelActions = new List<ParallelAction<ContactRequestMsgEntity>>();
            parallelActions.Add(new ParallelAction<ContactRequestMsgEntity>()
            {
                Action = IsCreateContactMsgEntityValid,
                Request = contactRequestMsgEntity
            });
            parallelActions.Add(new ParallelAction<ContactRequestMsgEntity>()
            {
                Action = IsCustomerNameValid,
                Request = contactRequestMsgEntity
            });
            parallelActions.Add(new ParallelAction<ContactRequestMsgEntity>()
            {
                Action = IsSubjectValid,
                Request = contactRequestMsgEntity
            });
            parallelActions.Add(new ParallelAction<ContactRequestMsgEntity>()
            {
                Action = IsMessageValid,
                Request = contactRequestMsgEntity
            });
            parallelActions.Add(new ParallelAction<ContactRequestMsgEntity>()
            {
                Action = IsEmailAddressValid,
                Request = contactRequestMsgEntity
            });

            return parallelProcessor.Execute<ContactRequestMsgEntity>(parallelActions).ToErrorMessages();

        }

        public List<ActionErrorMessage> IsCreateContactMsgEntityValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.IsEmpty())
                return KanakketuppuApiCoreUtility.GetErrorMessages(ContactServiceCoreErrorCode.CreateContactMsgEntityIsEmpty);
            return null;
        }

        public List<ActionErrorMessage> IsCustomerNameValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.CustomerName.IsEmpty())
                return KanakketuppuApiCoreUtility.GetErrorMessages(ContactServiceCoreErrorCode.CustomerNameIsEmpty);

            return null;
        }

        public List<ActionErrorMessage> IsSubjectValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.Subject.IsEmpty())
                return KanakketuppuApiCoreUtility.GetErrorMessages(ContactServiceCoreErrorCode.SubjectIsEmpty);
            return null;
        }

        public List<ActionErrorMessage> IsMessageValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.Message.IsEmpty())
                return KanakketuppuApiCoreUtility.GetErrorMessages(ContactServiceCoreErrorCode.MessageIsEmpty);
            return null;
        }

        public List<ActionErrorMessage> IsEmailAddressValid(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            if (contactRequestMsgEntity.EmailAddress.IsEmpty())
                return KanakketuppuApiCoreUtility.GetErrorMessages(ContactServiceCoreErrorCode.EmailAddressIsEmpty);
            return null;
        }

    }
}