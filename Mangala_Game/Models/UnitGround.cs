using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models
{
    public class UnitGround
    {

        private List<Unit> units;

        public UnitGround()
        {
            this.units = new List<Unit>();
        }

        public UnitGround(int initial_unit_number)
        {
            this.units = new List<Unit>();
            for(int i = 0; i < initial_unit_number; i++) units.Add(new Unit());
        }

        public bool InsertUnit(Unit insert_unit)
        {
            if (insert_unit.GetState() == UnitState.DISABLED) throw new Exceptions.InvalidUnitInsertionException();

            units.Add(insert_unit);
            return true;
        }

        public List<Unit> ExtractUnits()
        {
            if (units.Count == 0) throw new Exceptions.InvalidUnitGroundExtractionException();

            List<Unit> extract_units = units;
            units = new List<Unit>();
            return extract_units;
        }

        public bool ContainsUnit() { return units.Count > 0; }

        public int GetUnitNumber() { return units.Count; }

    }

}
