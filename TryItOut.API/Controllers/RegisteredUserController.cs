using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TryItOut.Service;

namespace TryItOut.API.Controllers
{
    public class RegisteredUserController : ApiController
    {
        // **********************
        // GET api/RegisteredUser
        // **********************
        [Route("Api/RegisteredUser/")]
        public string Get()
        {
            RegisteredUsersService regUsersService = new RegisteredUsersService();

            return JsonConvert.SerializeObject(regUsersService.Read());
        }

        // ************************
        // GET api/RegisteredUser/x
        // ************************
        [Route("Api/RegisteredUser/{identifier}")]
        public string Get(int identifier)
        {
            RegisteredUsersService regUsersService = new RegisteredUsersService();

            return JsonConvert.SerializeObject(regUsersService.Read(identifier));
        }

        // ************************
        // POST: api/RegisteredUser
        // ************************
        [Route("Api/RegisteredUser/")]
        public void Post([FromBody]JObject value)
        {
            RegisteredUsersService regUsersService = new RegisteredUsersService();

            if (value.HasValues) {

               var dto = value.ToObject(typeof(RegisteredUserDTO));
            }

            //var val = JsonConvert.DeserializeObject(value, typeof(RegisteredUserDTO));
        }


    }
}
