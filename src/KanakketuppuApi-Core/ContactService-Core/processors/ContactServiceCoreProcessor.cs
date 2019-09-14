namespace KanakketuppuApiCore.ContactServiceCore.Processors
{
    public class ContactServiceCoreProcessor : IContactServiceCoreProcessor
    {
        private readonly IKatavuccolRestClient katavuccolRestClient;
        private readonly IContactServiceCoreProcessorMapper contactServiceCoreProcessorMapper;
        public ContactServiceCoreProcessor(IKatavuccolRestClient katavuccolRestClient,
        IContactServiceCoreProcessorMapper contactServiceCoreProcessorMapper)
        {
            this.katavuccolRestClient = katavuccolRestClient;
        }

        public List<ErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {

        }
    }
}