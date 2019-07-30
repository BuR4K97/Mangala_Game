using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.GameExceptions
{
    public class InvalidUnitGroundIndexException : Exception
    {

        private const string MESSAGE = "Invalid index for accessing an unit ground(UnitGround)! See. Models.GameModels.PartialGameGround Class";

        public InvalidUnitGroundIndexException() : base(MESSAGE) {}

    }
}
