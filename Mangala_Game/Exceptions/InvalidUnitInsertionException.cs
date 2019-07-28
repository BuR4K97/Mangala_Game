using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions
{
    public class InvalidUnitInsertionException : Exception
    {

        private const string MESSAGE = "Invalid insertion for an Disabled(UnitState) unit! See. Models.UnitState Enum";

        public InvalidUnitInsertionException() : base(MESSAGE) {}

    }
}
