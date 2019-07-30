using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mangala_Game.Models.ServerModels
{
    public class UserProfile : ResponseData, IEquatable<UserProfile>
    {

        private int user_id;
        private string user_name;

        public UserProfile(int user_id, string user_name)
        {
            this.user_id = user_id;
            this.user_name = user_name;
        }

        public int GetUserId() { return this.user_id; }

        public string GetUserName() { return this.user_name; }

        public bool Equals(UserProfile other)
        {
            if (other == null) return false;
            return user_name.Equals(other.user_name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode() { return user_id; }

    }
}
