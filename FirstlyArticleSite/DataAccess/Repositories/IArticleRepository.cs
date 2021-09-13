using FirstlyArticleSite.DataAccess.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public interface IArticleRepository
    {
        List<Article> GetArticles();

        List<Article> Top10Articles();

        List<Article> RandomArticles();

        byte[] GetHeaderImageById(int id);

        List<Article> GetRandomArticlesByTopicId(int[] topicIds);

        Article GetArticle(int? articleId);

        List<Article> GetWriterArticles(int? userId);

        bool AddArticle(Article article);

        bool DeleteArticle(int? id);

        bool UpdateArticle(Article article);

        List<Article> GetSavedArticlesOfUser(int? id);

        bool SaveArticle(int userId, int articleId);

        bool UnsaveArticle(int userId, int articleId);

        bool LikeArticle(int? userId, int? articleId);

        bool DislikeArticle(int? userId, int? articleId);

        int GetLikeCount(int? articleId);
    }
}
