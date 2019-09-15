using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;

namespace KanakketuppuApiCore.ContactServiceCore.DataContracts
{
    public class ContactRequestMsgEntity : BaseMsgEntity
    {
        public string Message { get; set; }
        public string Subject { get; set; }
        public string EmailAddress { get; set; }
        public string CustomerName { get; set; }
    }
}