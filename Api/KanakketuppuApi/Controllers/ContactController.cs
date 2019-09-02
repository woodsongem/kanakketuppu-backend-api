using KanakketuppuApi.Model.ContactModel;
using Microsoft.AspNetCore.Mvc;

namespace KanakketuppuApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        // POST api/contact
        [HttpPost]
        public void Post(ContactRequestModel contactRequestModel)
        {
            
        }
    }
}