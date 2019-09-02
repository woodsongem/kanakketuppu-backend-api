using KanakketuppuApi.Model.ContactModel;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;

namespace KanakketuppuApi.Mappers.ConactApi
{
    public class ContactApiMapper : IContactApiMapper
    {
        public ContactRequestMsgEntity MapContactRequestMsgEntity(ContactRequestModel contactRequestModel)
        {
            if (contactRequestModel == null)
            {
                return null;
            }

            return new ContactRequestMsgEntity()
            {
                CustomerName = contactRequestModel.CustomerName,
                EmailAddress = contactRequestModel.EmailAddress,
                Message = contactRequestModel.Message,
                Subject = contactRequestModel.Subject
            };
        }
    }
}