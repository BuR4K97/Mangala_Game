using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.ServerExceptions
{
    public class UnregisteredUserSessionException : Exception
    {

        private const string MESSAGE = "Unregistered user session(UserSession) detected! See. Controllers.ServerControllers.RouterController Class";

        public UnregisteredUserSessionException() : base(MESSAGE) {}

    }
}
