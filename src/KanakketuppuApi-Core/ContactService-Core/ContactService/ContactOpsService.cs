using System;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.Mappers;
using KanakketuppuApiCore.ContactServiceCore.Processors;
using KanakketuppuApiCore.ContactServiceCore.Validations;
using KanakketuppuApiCore.DataContracts;
using KanakketuppuApiCore.Utilities;

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
        public Result CreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            //Setup
            contactRequestMsgEntity.CreatedOn = contactRequestMsgEntity.ModifiedOn = DateTime.UtcNow;
            contactRequestMsgEntity.CreatedBy = contactRequestMsgEntity.ModifiedBy = "ADMIN";

            //Validation
            var resultMessage = contactServiceValidation.ValidCreateContact(contactRequestMsgEntity);

            //Verifier
            resultMessage = contactServiceVerify.VerifyCreateContact(contactRequestMsgEntity);

            //Processor
            resultMessage = contactServiceProcessor.ProcessorCreateContact(contactRequestMsgEntity);

            return new Result() { ResultStatus = resultMessage.ToStatus(), ErrorMessages = resultMessage };
        }
    }
}