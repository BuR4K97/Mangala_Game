using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangala_Game.Models.ServerModels;
using Mangala_Game.Exceptions.ServerExceptions;

namespace Mangala_Game.Services
{
    
    public class SessionRegisterService : ISessionRegisterService
    {

        private Dictionary<UserProfile, UserSession> user_sessions;

        public SessionRegisterService()
        {
            this.user_sessions = new Dictionary<UserProfile, UserSession>();
        }

        public bool RegisterUserSession(UserSession user_session)
        {
            UserSession previous_session;
            if (user_sessions.TryGetValue(user_session.GetUserProfile(), out previous_session))
            {
                previous_session.SetSessionId(user_session.GetSessionId());
                throw new ActiveSessionException();
            }    
            else user_sessions.Add(user_session.GetUserProfile(), user_session);
            return true;
        }

        public bool GetAccessStatus(UserSession user_session)
        {
            UserSession active_session;
            if(user_sessions.TryGetValue(user_session.GetUserProfile(), out active_session))
                return user_session.Equals(active_session);
            return false;
        }

    }
}
