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
    public partial class RouterController
    {
        private readonly IGameRegisterService game_register_service;

        public RouterController(IGameRegisterService game_register_service)
        {
            this.game_register_service = game_register_service;
        }

        [HttpPost("RegisterGame")]
        public ActionResult<ResponsePackage> RegisterGamePost(GameProfile game_profile)
        {
            ResponsePackage response_package = new ResponsePackage();
            return Ok(response_package);
        }

    }
}
