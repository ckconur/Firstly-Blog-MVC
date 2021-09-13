using FirstlyArticleSite.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstlyArticleSite.DataAccess.DB;
using FirstlyArticleSite.Models;
using Microsoft.AspNetCore.Http;


namespace FirstlyArticleSite.Controllers
{
    public class ArticleController : Controller
    {
        IArticleRepository articleRepository;
        IUserRepository userRepository;
        ITopicRepository topicRepository;
        IModelMapper modelMapper;
        public ArticleController(IArticleRepository articleRepository, IUserRepository userRepository, ITopicRepository topicRepository, IModelMapper modelMapper)
        {
            this.articleRepository = articleRepository;
            this.userRepository = userRepository;
            this.topicRepository = topicRepository;
            this.modelMapper = modelMapper;
        }

        public IActionResult Article(int? id = null)
        {
            Article article = articleRepository.GetArticle(id);
            ArticleVM articleVM = modelMapper.ArticleToVmForRead(article);

            
            User user = userRepository.GetUser(article.WriterId);
            UserVM userVM = modelMapper.UserToVM(user, userRepository.GetBase64StringProfilePicture(user.UserId));

            ViewBag.Writer = userVM;
            ViewBag.LikeCount = articleRepository.GetLikeCount(id);
            return View(articleVM);
        }

        public IActionResult Write()
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            if (sessionId == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<Topic> topics = topicRepository.GetTopics();
            List<TopicVM> topicVMs = modelMapper.TopicsToVMs(topics);
            ViewBag.Topics = topicVMs;

            return View();
        }

        [HttpPost]
        public JsonResult PublishArticle(ArticleVM articleVM)
        {
            Article article = new Article()
            {
                WriterId = articleVM.WriterId,
                TopicId = articleVM.TopicId,
                Title = articleVM.Title,
                Content = articleVM.Content,
                HeaderImage = Convert.FromBase64String(articleVM.Base64HeaderImage),
                CreateDate = DateTime.Now,
                ViewCount = 0,
            };

            if (articleRepository.AddArticle(article))
            {
                return Json(new { redirectToUrl = Url.Action("Published", "User", article.WriterId) });
            }

            return Json("Hikaye yayınlanırken sıkıntı ile karşılaşıldı!");
        }
        
        public IActionResult Update(int? id = null)
        {
            Article article = articleRepository.GetArticle(id);
            ArticleVM articleVM = modelMapper.ArticleToVmForRead(article);

            List<Topic> topics = topicRepository.GetTopics();
            List<TopicVM> topicVMs = modelMapper.TopicsToVMs(topics);
            ViewBag.Topics = topicVMs;

            return View(articleVM);
        }


        [HttpPost]
        public JsonResult UpdateArticle(ArticleVM articleVM)
        {
            Article article = new Article()
            {
                ArticleId = articleVM.ArticleId,
                TopicId = articleVM.TopicId,
                Title = articleVM.Title,
                Content = articleVM.Content,
                HeaderImage = Convert.FromBase64String(articleVM.Base64HeaderImage),
            };

            if (articleRepository.UpdateArticle(article))
            {
                return Json(new { redirectToUrl = Url.Action("Published", "User", new { id = articleVM.WriterId }) });
            }

            return Json("Hikaye güncellenirken sıkıntı ile karşılaşıldı!");            
        }

        [HttpGet]
        public JsonResult DeleteArticle(int? id = null)
        {
            int? userId = HttpContext.Session.GetInt32("userId");
            if (id != null)
            {
                Article article = articleRepository.GetArticle(id);
                if (article.WriterId == userId)
                {
                    if (articleRepository.DeleteArticle(id))
                        return Json(new { redirectToUrl = Url.Action("Published", "User") });
                }
                return Json("Kullanıcının makaleyi düzenleme yetkisi yok");
            }

            return Json("Hikaye silinirken sıkıntı ile karşılaşıldı!");
        }

        public JsonResult Like(int? id = null)
        {
            int? sessionId = HttpContext.Session.GetInt32("userId");
            if (sessionId == null)
            {
                return Json(new { redirectToUrl = Url.Action("Login", "Home") });
            }

            if (id != null)
            {
                bool result = articleRepository.LikeArticle(sessionId, id);
                if (result)
                {
                    return Json($"{articleRepository.GetLikeCount(id)}");
                }
            }

            return Json(new { redirectToUrl = Url.Action("Index", "User") });
        }
    }
}
