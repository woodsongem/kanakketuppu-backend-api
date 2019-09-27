using System.Collections.Generic;
using RestClient.DataContracts;

namespace KanakketuppuApi_Core.ContactService_Core.datacontracts.externals
{
    public class CreateContactIPost : IPost
    {
        public object Request { get; set; }

        public string Url { get; }

        public List<RestClient.DataContracts.KeyValuePair> Headers { get; set; }
        public string Endpoint { get; set; }

    }
}