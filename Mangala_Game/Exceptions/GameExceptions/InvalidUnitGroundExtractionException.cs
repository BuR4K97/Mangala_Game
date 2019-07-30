using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.GameExceptions
{
    public class InvalidUnitGroundExtractionException : Exception
    {

        private const string MESSAGE = "Empty unit ground(UnitGround) extraction! See. Models.GameModels.UnitGround Class";

        public InvalidUnitGroundExtractionException() : base(MESSAGE) {}

    }
}
