using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models
{
    public enum UnitState { ENABLED, DISABLED }

    public class Unit
    {

        private UnitState state;

        public Unit()
        {
            this.state = UnitState.ENABLED;
        }

        public UnitState GetState()
        {
            return this.state;
        }

        public void SetState(UnitState state)
        {
            this.state = state;
        }

    }
}
