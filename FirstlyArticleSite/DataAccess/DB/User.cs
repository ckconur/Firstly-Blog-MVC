using System;
using System.Collections.Generic;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class User
    {
        public User()
        {
            Articles = new HashSet<Article>();
            Followings = new HashSet<Following>();
            LikedArticles = new HashSet<LikedArticle>();
            ProfilePictures = new HashSet<ProfilePicture>();
            SavedArticles = new HashSet<SavedArticle>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string AboutMe { get; set; }
        public string LoginGuid { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Following> Followings { get; set; }
        public virtual ICollection<LikedArticle> LikedArticles { get; set; }
        public virtual ICollection<ProfilePicture> ProfilePictures { get; set; }
        public virtual ICollection<SavedArticle> SavedArticles { get; set; }
    }
}
