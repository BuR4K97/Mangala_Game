using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models
{
    public class Player
    {

        private string name;
        private KeyValuePair<UnitStorage, PartialGameGround> ground;

        public Player(string name)
        {
            this.name = name;
        }

        public string GetName() { return this.name; }

        public void SetGround(KeyValuePair<UnitStorage, PartialGameGround> ground) { this.ground = ground; }

        public bool IsAccessible(PartialGameGround ground) { return this.ground.Value.Equals(ground); }

        public bool IsAccessible(UnitStorage ground) { return this.ground.Key.Equals(ground); }

        public bool ExecuteUnitGround(PartialGameGround execute_ground, int execute_index)
        {
            if (!IsAccessible(execute_ground)) throw new Exceptions.InvalidPlayerAccessException();
            return true;
        }

        public bool RetrieveIntoUnitStorage(UnitStorage unit_storage, Unit retrieve_unit)
        {
            if (!IsAccessible(unit_storage)) throw new Exceptions.InvalidPlayerAccessException();
            return true;
        }

    }
}
