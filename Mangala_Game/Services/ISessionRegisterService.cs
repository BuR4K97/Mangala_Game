using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangala_Game.Models.ServerModels;

namespace Mangala_Game.Services
{
    public interface ISessionRegisterService
    {

        bool RegisterUserSession(UserSession user_session);
        bool GetAccessStatus(UserSession user_session);

    }
}
