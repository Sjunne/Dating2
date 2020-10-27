using System;
using System.Threading.Tasks;
using MainServerAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace MainServerAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {

        public ProfileController()
        {
            
        }


        [HttpPost]
        public async Task<ActionResult<ProfileData>> AddProfile([FromBody]ProfileData profileData)
        {
            Console.WriteLine(profileData.intro);
            return Created($"/{1}", profileData);
        }
    }
}