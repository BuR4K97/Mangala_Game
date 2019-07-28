using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models
{
    public class UnitStorage
    {

        private readonly List<Unit> units;

        public UnitStorage()
        {
            this.units = new List<Unit>();
        }

        public bool InsertUnit(Unit insert_unit)
        {
            if (insert_unit.GetState() == UnitState.DISABLED) throw new Exceptions.InvalidUnitInsertionException();
            
            units.Add(insert_unit);
            insert_unit.SetState(UnitState.DISABLED);
            return true;
        }

        public bool InsertUnitList(List<Unit> insert_unit_list)
        {
            if (insert_unit_list.Exists(unit => unit.GetState() == UnitState.DISABLED)) throw new Exceptions.InvalidUnitInsertionException();
            if (insert_unit_list.Count == 0) throw new Exceptions.InvalidUnitListInsertionException();

            foreach (Unit insert_unit in insert_unit_list)
            {
                units.Add(insert_unit);
                insert_unit.SetState(UnitState.DISABLED);
            }
            return true;
        }

        public int GetUnitNumber() { return units.Count; }

    }
}
