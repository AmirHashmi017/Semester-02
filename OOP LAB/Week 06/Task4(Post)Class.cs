using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_4_lab_6_
{
    internal class Post
    {
        private string PostContent;
        private List<Like> Likes = new List<Like>();
        private List<Comment> Comments = new List<Comment>();
        public Post(string content)
        {
            this.PostContent = content;
        }
        public Post(string content, List<Like> likes, List<Comment> comments)
        {
            this.PostContent = content;
            this.Likes = likes;
            this.Comments = comments;
        }
        public void SetPostContent(string content)
        {
            PostContent = content;
        }
        public string GetPostContent()
        {
            return PostContent;
        }
        public void AddLike(User user)
        {
            Like like = new Like(user);
            Likes.Add(like);
        }
        public void AddComment(string content, User user)
        {
            Comment comment = new Comment(content, user);
            Comments.Add(comment);
        }
        public List<Like> GetLikes()
        {
            return Likes;
        }
        public List<Comment> GetComments()
        {
            return Comments;
        }
    }
}
