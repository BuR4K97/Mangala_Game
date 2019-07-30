using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Exceptions.ServerExceptions
{
    public class BadRegisterException : Exception
    {

        private const string MESSAGE = "Register request for a registered session(HttpContext.Session)! See. Controllers.ServerControllers.RouterController Class";

        public BadRegisterException() : base(MESSAGE) {}

    }
}
