using KanakketuppuApi_Core.ContactService_Core.datacontracts.externals;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Externals.Datacontracts;

namespace KanakketuppuApiCore.ContactServiceCore.Processors.Mappers
{
    public class ContactServiceCoreProcessorMapper : IContactServiceCoreProcessorMapper
    {
        public ContactApiModelEx MapContactApiModelEx(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            return new ContactApiModelEx()
            {
                CustomerName = contactRequestMsgEntity.CustomerName,
                EmailAddress = contactRequestMsgEntity.EmailAddress,
                Message = contactRequestMsgEntity.Message,
                Subject = contactRequestMsgEntity.Subject
            };
        }

        public CreateContactIPost MapCreateContactIPost(ContactApiModelEx contactApiModelEx)
        {
            return new CreateContactIPost()
            {
                Request = contactApiModelEx,
                
            };
        }
    }
}