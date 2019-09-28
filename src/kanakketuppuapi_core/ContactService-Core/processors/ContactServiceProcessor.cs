using System.Collections.Generic;
using KanakketuppuApiCore.ContactServiceCore.DataContracts;
using KanakketuppuApiCore.ContactServiceCore.DataContracts.Commons;
using KanakketuppuApiCore.Utilities;
using ParallelProcessors.DataContracts;
using ParallelProcessors.Processor;

namespace KanakketuppuApiCore.ContactServiceCore.Processors
{
    public class ContactServiceProcessor : IContactServiceProcessor
    {
        private readonly IContactServiceCoreProcessor contactServiceCoreProcessor;
        private readonly IParallelProcessor parallelProcessor;

        public ContactServiceProcessor(IContactServiceCoreProcessor contactServiceCoreProcessor,
                                       IParallelProcessor parallelProcessor)
        {
            this.contactServiceCoreProcessor = contactServiceCoreProcessor;
            this.parallelProcessor = parallelProcessor;
        }

        public List<ErrorMessage> ProcessorCreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            var parallelActions = new List<ParallelAction<ContactRequestMsgEntity>>();
            parallelActions.Add(new ParallelAction<ContactRequestMsgEntity>()
            {
                Action = CreateContact,
                Request = contactRequestMsgEntity
            });
            return parallelProcessor.Execute(parallelActions).ToErrorMessages();
        }

        public List<ActionErrorMessage> CreateContact(ContactRequestMsgEntity contactRequestMsgEntity)
        {
            return contactServiceCoreProcessor.CreateContact(contactRequestMsgEntity);
        }
    }
}