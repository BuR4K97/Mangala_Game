using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions
{
    public class InvalidUnitGroundIndexException : Exception
    {

        private const string MESSAGE = "Invalid index for accessing an unit ground(UnitGround)! See. Models.PartialGameGround Class";

        public InvalidUnitGroundIndexException() : base(MESSAGE) {}

    }
}
