using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions
{
    public class InvalidUnitGroundExtractionException : Exception
    {

        private const string MESSAGE = "Empty unit ground(UnitGround) extraction! See. Models.UnitGround Class";

        public InvalidUnitGroundExtractionException() : base(MESSAGE) {}

    }
}
