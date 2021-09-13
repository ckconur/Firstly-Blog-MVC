using Microsoft.AspNetCore.Http;
using FirstlyArticleSite.DataAccess.DB;
using FirstlyArticleSite.DataAccess.Repositories;
using FirstlyArticleSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.Controllers
{
    public class UserController : Controller
    {
        IUserRepository userRepository;
        IFollowingRepository followingRepository;
        ITopicRepository topicRepository;
        IArticleRepository articleRepository;
        IModelMapper modelMapper;
        public UserController(IUserRepository userRepository, IFollowingRepository followingRepository, ITopicRepository topicRepository, IArticleRepository articleRepository, IModelMapper modelMapper)
        {
            this.userRepository = userRepository;
            this.followingRepository = followingRepository;
            this.topicRepository = topicRepository;
            this.articleRepository = articleRepository;
            this.modelMapper = modelMapper;
        }

        public IActionResult Index()
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            UserVM userVM = null;
            if (userId != null)
            {
                User user = userRepository.GetUser(userId);
                userVM = modelMapper.UserToVM(user, userRepository.GetBase64StringProfilePicture(user.UserId));
            }

            else
            {
                string url = HttpContext.Request.Query["url"].ToString();
                string token = HttpContext.Request.Query["token"].ToString();

                User user = userRepository.FindUserByURL(url);

                if (user != null)
                {
                    if (user.LoginGuid == token)
                    {
                        HttpContext.Session.SetInt32("userId", user.UserId);
                        HttpContext.Session.SetString("url", user.Url);

                        userVM = modelMapper.UserToVM(user, userRepository.GetBase64StringProfilePicture(user.UserId));

                        userRepository.UpdateUserToken(user);
                    }
                    else
                    {
                        return Json("Gönderilen tokenlar uyuşmuyor!");
                    }
                }

                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }


            List<Article> articles = articleRepository.Top10Articles();
            List<ArticleVM> articleVMs = modelMapper.ArticlesToVMs(articles);
            ViewBag.MostViewed = articleVMs;

            articles = articleRepository.RandomArticles();
            articleVMs = modelMapper.ArticlesToVMs(articles);
            ViewBag.RandomArticles = articleVMs;

            return View(userVM);
        }

        public IActionResult GetFollowingTopics(int? id = null)
        {
            List<TopicVM> topicVMs = new List<TopicVM>();
            List<Topic> topics = topicRepository.GetFollowingTopics(followingRepository.FindFollowedTopicIDs(id));

            if (topics == null)
            {
                return PartialView("_FollowingTopics", topicVMs);
            }

            if (topics.Count == 0)
            {
                topics = topicRepository.GetTopics();
            }

            topicVMs = modelMapper.TopicsToVMs(topics);

            return PartialView("_FollowingTopics", topicVMs);
        }

        public IActionResult GetFollowingArticles(int? id = null)
        {
            List<Article> articles = articleRepository.GetRandomArticlesByTopicId(followingRepository.FindFollowedTopicIDs(id));
            List<ArticleVM> articleVMs = modelMapper.ArticlesToVMs(articles);


            return PartialView("_FollowingArticles", articleVMs);
        }

        public IActionResult Profile(string userName)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            UserVM userVM = null;
            if (sessionId != null)
            {
                User user = userRepository.GetUser(sessionId);

                userVM = modelMapper.UserToVM(user, userRepository.GetBase64StringProfilePicture(user.UserId));
            }

            return View(userVM);
        }

        [HttpPost]
        public IActionResult UpdateProfile(UserVM userVM)
        {
            User user = new User()
            {
                UserId = userVM.UserId,
                FirstName = userVM.FirstName,
                LastName = userVM.LastName,
                UserName = userVM.UserName,
                AboutMe = userVM.AboutMe,
                Email = userVM.Email,
                Url = userVM.Url
            };

            bool result1 = userRepository.Update(user);

            ProfilePicture newPP = new ProfilePicture()
            {
                UserId = userVM.UserId,
                Picture = Convert.FromBase64String(userVM.ProfilePicture)
            };

            bool result2 = userRepository.UpdatePP(newPP);

            if (result1 && result2)
            {
                HttpContext.Session.SetString("url", user.Url);
                return Json("Profil başarıyla güncellendi.");
            }

            return Json("Profil güncellenirken bir problemle karşılaşıldı !");
        }


        public IActionResult Logout(int? id = null)
        {
            User user = userRepository.GetUser(id);
            userRepository.UpdateUserToken(user);

            HttpContext.Session.Remove("userId");
            HttpContext.Session.Remove("url");

            return RedirectToAction("Index","Home");
        }

        public IActionResult DeleteProfile(int? id = null)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            if (sessionId != null && id != null && sessionId == id)
            {
                bool result = userRepository.DeleteUser(id);

                if (result)
                {
                    HttpContext.Session.Remove("userId");
                    HttpContext.Session.Remove("url");
                    return RedirectToAction("Index", "Home");                    
                }
            }

            return Json("Silinemedi");
        }

        public IActionResult Published(int? id = null)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            if (id == null && sessionId == null)
                return RedirectToAction("Index", "Home");
            else if (id != null && id != sessionId)
                return RedirectToAction("Index", "User");

            id = sessionId;

            List<Article> articles = articleRepository.GetWriterArticles(id);
            List<ArticleVM> articleVMs = modelMapper.ArticlesToVMs(articles);


            return View(articleVMs);
        }

        public IActionResult Saved(int? id = null)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            if (id == null && sessionId == null)
                return RedirectToAction("Index", "Home");
            else if (id != null && id != sessionId)
                return RedirectToAction("Index", "User");

            id = sessionId;

            List<Article> articles = articleRepository.GetSavedArticlesOfUser(id);
            List<ArticleVM> articleVMs = modelMapper.ArticlesToVMs(articles);

            return View(articleVMs);
        }

        public IActionResult SaveArticle(int? id = null)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            int? articleId = id;

            if (sessionId != null && articleId != null)
            {
                bool result = articleRepository.SaveArticle((int)sessionId, (int)articleId);
                if (result)
                {
                    return RedirectToAction("Article", "Article", new { id = articleId}); 
                }
                return Json("Makale kaydedilirken bir sıkıntı yaşandı");
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult UnsaveArticle(int? id = null)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            int? articleId = id;

            if (sessionId != null && articleId != null)
            {
                bool result = articleRepository.UnsaveArticle((int)sessionId, (int)articleId);
                if (result)
                {
                    return RedirectToAction("Saved", "User", new { id = sessionId });
                }
                return Json("Makale kaldırılırken bir sıkıntı yaşandı");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
