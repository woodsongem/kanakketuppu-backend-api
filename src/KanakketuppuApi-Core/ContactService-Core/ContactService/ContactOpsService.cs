using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.Mappers;
using KanakketuppuApiCore.ContactServiceCore.Validations;
using KanakketuppuApiCore.DataContracts;

namespace KanakketuppuApiCore.ContactServiceCore.ContactService
{
    public class ContactOpsService : IContactOpsService
    {
        private readonly IContactServiceValidation contactServiceValidation;
        private readonly IContactServiceVerify contactServiceVerify;
        private readonly IContactServiceMapper contactServiceMapper;

        public ContactOpsService(
                        IContactServiceValidation contactServiceValidation,
                        IContactServiceVerify contactServiceVerify,
                        IContactServiceMapper contactServiceMapper)
        {
            this.contactServiceValidation = contactServiceValidation;
            this.contactServiceVerify = contactServiceVerify;
            this.contactServiceMapper = contactServiceMapper;

        }
        public Result CreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}