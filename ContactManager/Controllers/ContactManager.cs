using ContactManager.MODELS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactManager : ControllerBase
    {
        [HttpGet]
        public Contact[] Get()
        {
            return new Contact[]
            {
                new Contact
                {
                    ID = 1,
                    Name ="David Sánchez"
                },
                new Contact
                {
                    ID= 2,
                    Name = "Daniel Olivo"
                }
            };
        }
    }
    
}
