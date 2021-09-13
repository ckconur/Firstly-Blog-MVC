using System;
using System.Collections.Generic;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class Article
    {
        public Article()
        {
            ArticlePictures = new HashSet<ArticlePicture>();
            LikedArticles = new HashSet<LikedArticle>();
            SavedArticles = new HashSet<SavedArticle>();
        }

        public int ArticleId { get; set; }
        public int WriterId { get; set; }
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int ViewCount { get; set; }
        public byte[] HeaderImage { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual User Writer { get; set; }
        public virtual ICollection<ArticlePicture> ArticlePictures { get; set; }
        public virtual ICollection<LikedArticle> LikedArticles { get; set; }
        public virtual ICollection<SavedArticle> SavedArticles { get; set; }
    }
}
