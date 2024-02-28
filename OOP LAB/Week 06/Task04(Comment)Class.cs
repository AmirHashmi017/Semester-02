using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_lab_6_
{
    internal class Comment
    {
        private string Content;
        private User UserComment;
        public Comment(string content, User user)
        {
            this.Content = content;
            this.UserComment = user;
        }
        public void SetContent(string content)
        {
            Content = content;
        }
        public string GetContent()
        {
            return Content;
        }
        public User GetUserComment()
        {
            return UserComment;
        }
    }
}
