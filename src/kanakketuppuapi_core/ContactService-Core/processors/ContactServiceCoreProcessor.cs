using System.Collections.Generic;
using KanakketuppuApi_Core.ContactService_Core.datacontracts.externals;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Externals.Datacontracts;
using KanakketuppuApiCore.ContactServiceCore.Processors.Mappers;
using ParallelProcessors.DataContracts;
using RestClient.Client;
using RestClient.DataContracts;

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
            this.contactServiceCoreProcessorMapper = contactServiceCoreProcessorMapper;
        }

        public List<ActionErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            ContactApiModelEx contactApiModelEx = contactServiceCoreProcessorMapper.MapContactApiModelEx(contactRequestMsgEntity);
            CreateContactIPost createContactIPost = contactServiceCoreProcessorMapper.MapCreateContactIPost(contactApiModelEx);
            RestResponse restResponse = katavuccolRestClient.Post(createContactIPost);
            return null;
        }
    }
}