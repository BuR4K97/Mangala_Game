using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Mangala_Game.Services;
using Mangala_Game.Models.ServerModels;
using Mangala_Game.Exceptions.ServerExceptions;

namespace Mangala_Game.Controllers.ServerControllers
{
    [Route("Mangala_Game/")]
    [ApiController]
    public class RouterController : ControllerBase
    {
        private const string USERID_KEY = "user_id";
        private const string USERNAME_KEY = "user_name";
        
        private readonly ISessionRegisterService session_register_service;

        public RouterController(ISessionRegisterService session_register_service)
        {
            this.session_register_service = session_register_service;
        }

        [HttpPost("Register")]
        public ActionResult<UserProfile> RegisterPost(UserProfile user_profile)
        {
            try
            {
                GetUserSession();
                return BadRequest(new BadRegisterException());
            }
            catch(UnregisteredUserSessionException exception_1)
            {
                try
                {
                    session_register_service.RegisterUserSession(new UserSession(user_profile, HttpContext.Session.Id));
                }
                catch (ActiveSessionException exception_2) { }
                HttpContext.Session.SetString(USERID_KEY, user_profile.GetUserId().ToString());
                HttpContext.Session.SetString(USERNAME_KEY, user_profile.GetUserName());
                return Ok(user_profile);
            }
        }

        private UserSession GetUserSession()
        {
            string user_id = HttpContext.Session.GetString(USERID_KEY);
            string user_name = HttpContext.Session.GetString(USERNAME_KEY);
            if (!string.IsNullOrEmpty(user_id) && !string.IsNullOrEmpty(user_name))
                return new UserSession(new UserProfile(Convert.ToInt32(user_id), user_name), HttpContext.Session.Id);
            throw new UnregisteredUserSessionException();
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
