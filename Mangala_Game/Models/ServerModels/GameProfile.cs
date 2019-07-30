using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models.ServerModels
{
    public class GameProfile : ResponseData
    {

        private int game_id;
        private string game_name;

        public GameProfile(int game_id, string game_name)
        {
            this.game_id = game_id;
            this.game_name = game_name;
        }
    }
}
