using FirstlyArticleSite.DataAccess.DB;
using FirstlyArticleSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public interface IModelMapper
    {
        List<ArticleVM> ArticlesToVMs(List<Article> articles);

        ArticleVM ArticleToVmForRead(Article article);

        List<TopicVM> TopicsToVMs(List<Topic> topics);

        UserVM UserToVM(User user, string base64Image);
    }
}
