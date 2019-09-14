namespace KanakketuppuApiCore.ContactServiceCore.Processors
{
    public class ContactServiceProcessor : IContactServiceProcessor
    {
        private readonly IContactServiceCoreProcessor contactServiceCoreProcessor;
        public ContactServiceProcessor(IContactServiceCoreProcessor contactServiceCoreProcessor)
        {
            this.contactServiceCoreProcessor = contactServiceCoreProcessor;
        }
        public List<ErrorMessage> ProcessorCreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {

        }

        public List<ErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            return contactServiceCoreProcessor.CreateContact(contactRequestMsgEntity);
        }
    }
}