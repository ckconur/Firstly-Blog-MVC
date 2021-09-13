using FirstlyArticleSite.DataAccess.DB;
using FirstlyArticleSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public class ModelMapper: IModelMapper
    {
        public List<ArticleVM> ArticlesToVMs(List<Article> articles)
        {
            List<ArticleVM> articleVMs = new List<ArticleVM>();

            foreach (Article item in articles)
            {
                ArticleVM articleVM = new ArticleVM()
                {
                    ArticleId = item.ArticleId,
                    Content = item.Content,
                    CreateDate = item.CreateDate,
                    HeaderImage = item.HeaderImage,
                    Title = item.Title,
                    TopicId = item.TopicId,
                    ViewCount = item.ViewCount,
                    WriterId = item.WriterId
                };

                articleVMs.Add(articleVM);
            }

            return articleVMs;
        }

        public ArticleVM ArticleToVmForRead(Article article)
        {
            ArticleVM articleVM = new ArticleVM()
            {
                ArticleId = article.ArticleId,
                Title = article.Title,
                Content = article.Content,
                CreateDate = article.CreateDate,
                TopicId = article.TopicId,
                ViewCount = article.ViewCount,
                HeaderImage = article.HeaderImage,
                WriterId = article.WriterId,
                AvarageReadingTime = Convert.ToDecimal(article.Content.Length) / 250
            };

            return articleVM;
        }

        public List<TopicVM> TopicsToVMs(List<Topic> topics)
        {
            List<TopicVM> topicVMs = new List<TopicVM>();
            foreach (Topic item in topics)
            {
                TopicVM topicVM = new TopicVM()
                {
                    TopicId = item.TopicId,
                    TopicName = item.TopicName
                };

                topicVMs.Add(topicVM);
            }
            return topicVMs;
        }

        public UserVM UserToVM(User user, string base64Image)
        {
            UserVM userVM = new UserVM()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Url = user.Url,
                AboutMe = user.AboutMe,
                ProfilePicture = base64Image,
                Email = user.Email
            };

            return userVM;
        }
    }
}
