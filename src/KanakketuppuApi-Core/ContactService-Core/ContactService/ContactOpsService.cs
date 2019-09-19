using System;
using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using KanakketuppuApiCore.ContactServiceCore.Mappers;
using KanakketuppuApiCore.ContactServiceCore.Processors;
using KanakketuppuApiCore.ContactServiceCore.Validations;
using KanakketuppuApiCore.DataContracts;
using KanakketuppuApiCore.Utilities;
using KatavuccolCommon.Extensions;

namespace KanakketuppuApiCore.ContactServiceCore.ContactService
{
    public class ContactOpsService : IContactOpsService
    {
        private readonly IContactServiceValidation contactServiceValidation;
        private readonly IContactServiceVerify contactServiceVerify;
        private readonly IContactServiceMapper contactServiceMapper;
        private readonly IContactServiceProcessor contactServiceProcessor;

        public ContactOpsService(
            IContactServiceValidation contactServiceValidation,
            IContactServiceVerify contactServiceVerify,
            IContactServiceMapper contactServiceMapper,
            IContactServiceProcessor contactServiceProcessor)
        {
            this.contactServiceValidation = contactServiceValidation;
            this.contactServiceVerify = contactServiceVerify;
            this.contactServiceMapper = contactServiceMapper;
            this.contactServiceProcessor = contactServiceProcessor;
        }
        public List<ErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            //Setup
            contactRequestMsgEntity.CreatedOn = contactRequestMsgEntity.ModifiedOn = DateTime.UtcNow;
            contactRequestMsgEntity.CreatedBy = contactRequestMsgEntity.ModifiedBy = "ADMIN";

            //Validation
            var resultMessage = contactServiceValidation.ValidCreateContact(contactRequestMsgEntity);
            if (resultMessage.AnyWithNullCheck())
            {
                return resultMessage;
            }

            //Verifier
            resultMessage = contactServiceVerify.VerifyCreateContact(contactRequestMsgEntity);
            if (resultMessage.AnyWithNullCheck())
            {
                return resultMessage;
            }

            //Processor
            resultMessage = contactServiceProcessor.ProcessorCreateContact(contactRequestMsgEntity);
            if (resultMessage.AnyWithNullCheck())
            {
                return resultMessage;
            }

            return resultMessage;
        }
    }
}