namespace KanakketuppuApiCore.ContactServiceCore.Processors
{
    public interface IContactServiceCoreProcessor
    {
        List<ErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
    }
}