using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_lab_6_
{
    internal class User
    {
        private string UserName;
        private List<Post> Posts;
        private List<User> Followers;
        private List<User> Followings;

        public User(string name)
        {
            this.UserName = name;
            Posts = new List<Post>();
            Followers = new List<User>();
            Followings = new List<User>();
        }
        public void SetUserName(string name)
        {
            UserName = name;
        }
        public string GetUserName()
        {
            return UserName;
        }
        public void AddUserPost(Post post)
        {
            Posts.Add(post);
        }
        public List<Post> GetPosts()
        {
            return Posts;
        }
        public void AddFollower(User follower)
        {
            Followers.Add(follower);
        }
        public void AddFollowings(User followings)
        {
            Followings.Add(followings);
        }
        public List<User> GetFollowers()
        {
            return Followers;
        }
        public List<User> GetFollowings()
        {
            return Followings;
        }
    }
}
