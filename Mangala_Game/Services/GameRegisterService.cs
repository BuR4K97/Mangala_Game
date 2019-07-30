using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangala_Game.Models.ServerModels;

namespace Mangala_Game.Services
{
    public class GameRegisterService : IGameRegisterService
    {

        private Dictionary<GameProfile, GameSession> game_sessions;

        public GameRegisterService()
        {
            this.game_sessions = new Dictionary<GameProfile, GameSession>();
        }

    }
}
