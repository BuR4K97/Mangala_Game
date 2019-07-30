using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangala_Game.Exceptions.GameExceptions;

namespace Mangala_Game.Models
{
    public class PartialGameGround
    {

        public const int UNIT_GROUND_NUMBER = 6;

        private List<UnitGround> unit_grounds;

        public PartialGameGround()
        {
            unit_grounds = new List<UnitGround>(UNIT_GROUND_NUMBER);
            for (int i = 0; i < UNIT_GROUND_NUMBER; i++) unit_grounds.Add(new UnitGround());
        }

        public PartialGameGround(int initial_unit_number)
        {
            unit_grounds = new List<UnitGround>(UNIT_GROUND_NUMBER);
            for (int i = 0; i < UNIT_GROUND_NUMBER; i++) unit_grounds.Add(new UnitGround(initial_unit_number));
        }

        public UnitGround GetUnitGround(int index)
        {
            if (index < 0 || index > UNIT_GROUND_NUMBER - 1) throw new InvalidUnitGroundIndexException();
            return unit_grounds[index];
        }

    }
}
