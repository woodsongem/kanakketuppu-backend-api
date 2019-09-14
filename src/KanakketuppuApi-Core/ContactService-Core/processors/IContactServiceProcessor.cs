namespace KanakketuppuApiCore.ContactServiceCore.Processors
{
    public interface IContactServiceProcessor
    {
        List<ErrorMessage> ProcessorCreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
        List<ErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity);
        
    }
}