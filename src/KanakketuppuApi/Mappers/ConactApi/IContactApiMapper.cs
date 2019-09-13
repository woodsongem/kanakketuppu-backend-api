using KanakketuppuApi.Model.ContactModel;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;

namespace KanakketuppuApi.Mappers.ConactApi
{
    public interface IContactApiMapper
    {
        ContactRequestMsgEntity MapContactRequestMsgEntity(ContactRequestModel contactRequestModel);
    }
}