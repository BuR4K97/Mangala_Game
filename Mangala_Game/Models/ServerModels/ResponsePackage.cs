using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangala_Game.Exceptions.ServerExceptions;

namespace Mangala_Game.Models.ServerModels
{
    public class ResponsePackage
    {
        public ResponseData response_data;
        public ServerException server_exception;
    }

    public class ResponseData { }

    public enum ServerException { NONE, ACTIVE_SESSION_EXCEPTION, BAD_REGISTER_EXCEPTION, UNREGISTERED_USERSESSION_EXCEPTION }

    public static class ServerExceptionExtension {

        public static void ThrowException(this ServerException server_exception)
        {
            switch (server_exception)
            {
                case ServerException.ACTIVE_SESSION_EXCEPTION: throw new ActiveSessionException();
                case ServerException.BAD_REGISTER_EXCEPTION: throw new BadRegisterException();
                case ServerException.UNREGISTERED_USERSESSION_EXCEPTION: throw new UnregisteredUserSessionException();
            }
        }

    }
}
