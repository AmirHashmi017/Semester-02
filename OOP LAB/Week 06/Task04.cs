using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_lab_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User("Amir");
            User u2 = new User("Ali");
            User u3 = new User("Ashir");
            u1.AddFollower(u2);
            u1.AddFollower(u3);
            u1.AddFollowings(u2);
            u1.AddFollowings(u3);
            Post p1 = new Post(" Welcome to OOP");
            p1.AddLike(u2);
            p1.AddLike(u3);
            p1.AddComment(" Great Work", u2);
            p1.AddComment(" Excellent Start", u2);
            Post p2 = new Post(" Welcome to Coding");
            p2.AddLike(u2);
            p2.AddLike(u3);
            p2.AddComment(" Great Initiative", u2);
            p2.AddComment(" Superb!!", u2);
            u1.AddUserPost(p1);
            u1.AddUserPost(p2);
            List<User> followers = new List<User>();
            followers = u1.GetFollowers();
            List<User> followings = new List<User>();
            followings = u1.GetFollowings();
            Console.Write($" {u1.GetUserName()} have followers {followers[0].GetUserName()} and Followings {followings[1].GetUserName()} ");
            Console.Write($" \nHis Posts are {u1.GetUserName()}");
            List<Post> posts = new List<Post>();
            posts = u1.GetPosts();
            List<Like> likes = new List<Like>();
            List<Comment> comments = new List<Comment>();
            foreach (Post p in posts)
            {
                likes = p.GetLikes();
                comments = p.GetComments();
                Console.WriteLine($" Post: {p.GetPostContent()}");
                foreach (Like l in likes)
                    Console.WriteLine($" {l.GetUserLike().GetUserName()} liked this post.");
                foreach (Comment c in comments)
                    Console.WriteLine($" {c.GetUserComment().GetUserName()} Commented {c.GetContent()} on this post.");
            }
            Console.ReadKey();
        }
    }
}
