using System;
using System.Runtime.Serialization;

namespace Mangala_Game.Exceptions
{
    [Serializable]
    internal class InvalidPlayerAccessException : Exception
    {

        private const string MESSAGE = "Invalid access into unit storage(UnitStorage) or partial game ground(PartialGameGround) for a player(Player)! See. Models.Player Class";
        public InvalidPlayerAccessException() : base(MESSAGE) {}

    }
}