using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models
{
    public class GameGround
    {

        public const int UNITSTORAGE_NUMBER = MangalaGame.PLAYER_NUMBER;
        public const int PARTIAL_GAMEGROUND_NUMBER = MangalaGame.PLAYER_NUMBER;

        private readonly List<UnitStorage> unit_storages;
        private readonly List<PartialGameGround> partial_game_grounds;

        public GameGround()
        {
            unit_storages = new List<UnitStorage>(UNITSTORAGE_NUMBER);
            partial_game_grounds = new List<PartialGameGround>(PARTIAL_GAMEGROUND_NUMBER);
            for (int i = 0; i < UNITSTORAGE_NUMBER; i++) unit_storages.Add(new UnitStorage());
            for (int i = 0; i < PARTIAL_GAMEGROUND_NUMBER; i++) partial_game_grounds.Add(new PartialGameGround());
        }

        public GameGround(int initial_unit_number)
        {
            unit_storages = new List<UnitStorage>(UNITSTORAGE_NUMBER);
            partial_game_grounds = new List<PartialGameGround>(PARTIAL_GAMEGROUND_NUMBER);
            for (int i = 0; i < UNITSTORAGE_NUMBER; i++) unit_storages.Add(new UnitStorage());
            for (int i = 0; i < PARTIAL_GAMEGROUND_NUMBER; i++) partial_game_grounds.Add(new PartialGameGround(initial_unit_number));
        }

        public UnitStorage GetUnitStorage(int index)
        {
            if (index < 0 || index > UNITSTORAGE_NUMBER - 1) throw new Exceptions.InvalidUnitStorageIndexException();
            return unit_storages[index];
        }

        public PartialGameGround GetPartialGameGround(int index)
        {
            if (index < 0 || index > PARTIAL_GAMEGROUND_NUMBER - 1) throw new Exceptions.InvalidPartialGameGroundIndexException();
            return partial_game_grounds[index];
        }

    }
}
