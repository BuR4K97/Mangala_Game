using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.GameExceptions
{
    public class InvalidUnitListInsertionException : Exception
    {

        private const string MESSAGE = "Empty list insertion into an unit storage(UnitStorage)! See. Models.GameModels.UnitStorage Class";

        public InvalidUnitListInsertionException() : base(MESSAGE) {}

    }
}
