using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models.ServerModels
{
    public class UserSession : IEquatable<UserSession>
    {

        private UserProfile user_profile;
        private string session_id;

        public UserSession(UserProfile user_profile, string session_id)
        {
            this.user_profile = user_profile;
            this.session_id = session_id;
        }

        public UserProfile GetUserProfile() { return this.user_profile; }

        public void SetSessionId(string session_id) { this.session_id = session_id; }

        public string GetSessionId() { return this.session_id; }

        public bool Equals(UserSession other) {  return this.session_id.Equals(other.session_id); }
    }
}
