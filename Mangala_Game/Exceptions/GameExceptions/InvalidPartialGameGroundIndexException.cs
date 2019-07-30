using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.GameExceptions
{
    public class InvalidPartialGameGroundIndexException : Exception
    {

        private const string MESSAGE = "Invalid index for accessing a partial game ground(PartialGameGround)! See. Models.GameModels.GameGround Class";

        public InvalidPartialGameGroundIndexException() : base(MESSAGE) {}

    }
}
