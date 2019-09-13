namespace KanakketuppuApiCore.ContactServiceCore.DataContracts
{
    public class ContactRequestMsgEntity
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerName { get; set; }
    }
}