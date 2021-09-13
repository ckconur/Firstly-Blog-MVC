using FirstlyArticleSite.DataAccess.DB;
using FirstlyArticleSite.DataAccess.Repositories;
using FirstlyArticleSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.Controllers
{
    public class TopicsController : Controller
    {
        ITopicRepository topicRepository;
        IFollowingRepository followingRepository;
        IArticleRepository articleRepository;
        IModelMapper modelMapper;
        public TopicsController(ITopicRepository topicRepository, IFollowingRepository followingRepository,IArticleRepository articleRepository, IModelMapper modelMapper)
        {
            this.followingRepository = followingRepository;
            this.topicRepository = topicRepository;
            this.articleRepository = articleRepository;
            this.modelMapper = modelMapper;
        }

        public IActionResult List(int? id = null)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            if (sessionId != null && id != null && sessionId == id)
            {
                return View();                
            }

            return Json("giriş yapan kullanıcı bulunmuyor");
        }

        public PartialViewResult FollowingList(int? id = null)
        {
            List<TopicVM> topicVMs = null;
            if (id != null)
            {
                int[] topicIds = followingRepository.FindFollowedTopicIDs(id);
                List<Topic> topics = topicRepository.GetFollowingTopics(topicIds);
                topicVMs = new List<TopicVM>();

                if (topics == null)
                {
                    return PartialView("_FollowingList", topicVMs);
                }

                topicVMs = modelMapper.TopicsToVMs(topics);
            }

            return PartialView("_FollowingList",topicVMs);
        }

        public PartialViewResult UnfollowingList(int? id = null)
        {
            List<TopicVM> topicVMs = null;
            if (id != null)
            {
                int[] topicIds = followingRepository.FindFollowedTopicIDs(id);
                List<Topic> topics = topicRepository.GetUnfollowingTopics(topicIds);
                topicVMs = new List<TopicVM>();

                topicVMs = modelMapper.TopicsToVMs(topics);
            }

            return PartialView("_UnfollowingList", topicVMs);
        }

        public JsonResult FollowTopic(int? id = null)
        {
            Following following = new Following() { 
                UserId = (int)HttpContext.Session.GetInt32("userId"),
                TopicId = (int)id            
            };

            if (followingRepository.AddFollowing(following))
            {
                return Json("OK");
            }

            return Json("NO");
        }

        public JsonResult UnfollowTopic(int? id = null)
        {

            Following following = new Following()
            {
                UserId = (int)HttpContext.Session.GetInt32("userId"),
                TopicId = (int)id
            };

            if (followingRepository.DeleteFollowing(following))
            {
                return Json("OK");
            }

            return Json("NO");
        }

        public IActionResult AllTopics()
        {
            List<Topic> topics = topicRepository.GetTopics();
            List<TopicVM> topicVMs = modelMapper.TopicsToVMs(topics);

            return View(topicVMs);
        }

        public IActionResult ArticlesOfTopic(int? id = null)
        {
            if (id != null)
            {
                int[] topicId = new int[] { (int)id };
                List<Article> articles = articleRepository.GetRandomArticlesByTopicId(topicId);
                List<ArticleVM> articleVMs = modelMapper.ArticlesToVMs(articles);

                return PartialView("_ArticleOfTopic", articleVMs); 
            }

            return Json("Bir sıkıntı ile karşılaşıldı");
        }
    }
}
