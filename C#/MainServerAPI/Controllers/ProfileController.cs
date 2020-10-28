using System;
using System.Threading.Tasks;
using MainServerAPI.Data;
using MainServerAPI.Network;
using Microsoft.AspNetCore.Mvc;

namespace MainServerAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
        private INetwork _network;

        public ProfileController(INetwork network)
        {
            _network = network;
        }

        [HttpPost]
        public async Task<ActionResult<ProfileData>> AddProfile([FromBody]ProfileData profileData)
        {
            _network.updateProfile(profileData);
            return Created($"/{profileData.username}", profileData);
        }
    }
}