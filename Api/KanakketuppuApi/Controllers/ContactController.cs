using KanakketuppuApi.Mappers.ConactApi;
using KanakketuppuApi.Model.ContactModel;
using KanakketuppuApiCore.ContactServiceCore.ContactService;
using Microsoft.AspNetCore.Mvc;

namespace KanakketuppuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;
        private readonly IContactApiMapper contactApiMapper;
        public ContactController(IContactService contactService, IContactApiMapper contactApiMapper)
        {
            this.contactService = contactService;
            this.contactApiMapper = contactApiMapper;
        }

        // POST api/contact
        [HttpPost]
        public void Post(ContactRequestModel contactRequestModel)
        {
            var contactRequestMsgEntity = contactApiMapper.MapContactRequestMsgEntity(contactRequestModel);
            var result = contactService.CreateContact(contactRequestMsgEntity);
        }
    }
}