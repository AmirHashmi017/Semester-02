using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_lab_6_
{
    internal class Like
    {
        private User UserLike;
        public Like(User user)
        {
            this.UserLike = user;
        }
        public User GetUserLike()
        {
            return UserLike;
        }
    }
}
