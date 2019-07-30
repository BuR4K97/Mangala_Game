using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.GameExceptions
{
    public class InvalidUnitStorageIndexException : Exception
    {

        private const string MESSAGE = "Invalid index for accessing an unit storage(UnitStorage)! See. Models.GameModels.GameGround Class";

        public InvalidUnitStorageIndexException() : base(MESSAGE) {}

    }
}
