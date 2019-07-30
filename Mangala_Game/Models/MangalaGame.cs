using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models
{
    public class MangalaGame
    {

        public const int PLAYER_NUMBER = 2;
        //private const int INITIAL_UNIT_NUMBER = 4;

        private readonly List<Player> players;
        private readonly GameGround game_ground;

        public MangalaGame(List<string> player_names)
        {
            this.players = new List<Player>(PLAYER_NUMBER);
            this.game_ground = new GameGround(INITIAL_UNIT_NUMBER);
        }

    }

}
