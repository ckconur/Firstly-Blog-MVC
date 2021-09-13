using FirstlyArticleSite.DataAccess.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        FirstlyBlogDBContext context;

        public ArticleRepository(FirstlyBlogDBContext context)
        {
            this.context = context;
        }


        public List<Article> GetArticles()
        {
            List<Article> articles = context.Articles.ToList<Article>();

            return articles;
        }


        public List<Article> Top10Articles()
        {
            List<Article> topArticles = context.Articles.OrderByDescending(a => a.ViewCount).Take(10).ToList();

            return topArticles;
        }

        public List<Article> RandomArticles()
        {
            List<Article> articles = GetArticles();
            List<Article> randomArticle = new List<Article>();
            Random rnd = new Random();
            for (int i = 0; i < articles.Count; i++)
            {
                if (randomArticle.Count == 10)
                    break;

                int index = rnd.Next(articles.Count);

                Article article = articles[index];

                if (randomArticle.Contains(article))
                {
                    i--;
                    continue;
                }

                randomArticle.Add(article);
            }

            return randomArticle;
        }

        public byte[] GetHeaderImageById(int id)
        {
            Article article = context.Articles.SingleOrDefault(a => a.ArticleId == id);

            return article.HeaderImage;
        }

        public List<Article> GetRandomArticlesByTopicId(int[] topicIds)
        {
            List<Article> articles = new List<Article>();

            foreach (int item in topicIds)
            {
                List<Article> articles1 = context.Articles.Where(a => a.TopicId == item).ToList();

                articles.AddRange(articles1);
            }

            List<Article> randomArticle = new List<Article>();
            Random rnd = new Random();
            for (int i = 0; i < articles.Count; i++)
            {
                if (randomArticle.Count == 10)
                    break;

                int index = rnd.Next(articles.Count);

                Article article = articles[index];

                if (randomArticle.Contains(article))
                {
                    i--;
                    continue;
                }

                randomArticle.Add(article);
            }

            return randomArticle;
        }

        public List<Article> GetSavedArticlesOfUser(int? id)
        {
            int[] savedArticleIds = context.SavedArticles.Where(a => a.UserId == id).Select(a => a.ArticleId).ToArray();
            List<Article> articles = new List<Article>();

            foreach (int item in savedArticleIds)
            {
                List<Article> articles1 = context.Articles.Where(a => a.ArticleId == item).ToList();

                articles.AddRange(articles1);
            }

            return articles;
        }
        public bool SaveArticle(int userId, int articleId)
        {
            List<Article> articles = GetSavedArticlesOfUser(userId);
            Article article = articles.SingleOrDefault(a => a.ArticleId == articleId);
            if (article != null)
                return true;

            else
            {
                SavedArticle savedArticle = new SavedArticle()
                {
                    UserId = userId,
                    ArticleId = articleId,
                };
                context.SavedArticles.Add(savedArticle);
            }

            int result = context.SaveChanges();

            if (result > 0)
                return true;

            return false;
        }

        public bool UnsaveArticle(int userId, int articleId)
        {
            SavedArticle savedArticle = context.SavedArticles.SingleOrDefault(a => a.UserId == userId && a.ArticleId == articleId);
            context.SavedArticles.Remove(savedArticle);
            int result = context.SaveChanges();

            if (result > 0)
                return true;

            return false;
        }

        public Article GetArticle(int? articleId)
        {
            Article article = context.Articles.SingleOrDefault(a => a.ArticleId == articleId);
            if (article != null)
                article.ViewCount += 1;             
            
            context.SaveChanges();
            return article;
        }

        public List<Article> GetWriterArticles(int? userId)
        {
            List<Article> articles = context.Articles.Where(a => a.WriterId == userId).OrderByDescending(a => a.CreateDate).ToList();

            return articles;
        }

        public bool AddArticle(Article article)
        {
            context.Articles.Add(article);
            int result = context.SaveChanges();
            if (result > 0)
                return true;

            return false;
        }

        public bool DeleteArticle(int? id)
        {
            List<ArticlePicture> articlePictures = context.ArticlePictures.Where(a => a.ArticleId == id).ToList();
            List<LikedArticle> likedArticles = context.LikedArticles.Where(a => a.ArticleId == id).ToList();
            List<SavedArticle> savedArticles = context.SavedArticles.Where(a => a.ArticleId == id).ToList();

            Article article1 = context.Articles.Find(id);

            context.ArticlePictures.RemoveRange(articlePictures);
            context.LikedArticles.RemoveRange(likedArticles);
            context.SavedArticles.RemoveRange(savedArticles);
            context.Articles.Remove(article1);

            if (context.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool UpdateArticle(Article article)
        {
            Article article1 = context.Articles.SingleOrDefault(a => a.ArticleId == article.ArticleId);
            article1.Title = article.Title;
            article1.Content = article.Content;
            article1.HeaderImage = article.HeaderImage;
            article1.TopicId = article.TopicId;
            if (context.SaveChanges() > 0)
                return true;
            return false;
        }

        public bool LikeArticle(int? userId, int? articleId)
        {
            
            if (!GetLikeState(userId, articleId))
            {
               return DislikeArticle(userId, articleId);
            }

            LikedArticle newLikedArticle = new LikedArticle()
            {
                UserId = (int)userId,
                ArticleId = (int)articleId
            };

            context.LikedArticles.Add(newLikedArticle);
            int result = context.SaveChanges();
            if (result > 0)
                return true;
            return false;
        }
        public bool DislikeArticle(int? userId, int? articleId)
        {
            LikedArticle likedArticle = context.LikedArticles.SingleOrDefault(a => a.UserId == userId && a.ArticleId == articleId);
            if (likedArticle != null)
            {
                context.LikedArticles.Remove(likedArticle);
            }

            int result = context.SaveChanges();
            if (result > 0)
                return true;
            return false;
        }

        public int GetLikeCount(int? articleId)
        {
            return  context.LikedArticles.Where(a => a.ArticleId == articleId).Count();
        }

        private bool GetLikeState(int? userId, int? articleId)
        {
            LikedArticle likedArticle = context.LikedArticles.SingleOrDefault(a => a.UserId == userId && a.ArticleId == articleId);

            if (likedArticle == null)
                return true;
            return false;
        }
    }
}
