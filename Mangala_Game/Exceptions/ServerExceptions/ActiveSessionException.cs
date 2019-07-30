using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.ServerExceptions
{
    public class ActiveSessionException : Exception
    {

        private const string MESSAGE = "Already active session(UserSession) registered! See. Services.SessionRegisterService Class";

        public ActiveSessionException() : base(MESSAGE) {}
    }
}
