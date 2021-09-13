using FirstlyArticleSite.DataAccess.DB;
using FirstlyArticleSite.DataAccess.Repositories;
using FirstlyArticleSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FirstlyArticleSite.Controllers
{
    public class HomeController : Controller
    {
        IArticleRepository articleRepository;
        IUserRepository userRepository;
        IModelMapper modelMapper;
        public HomeController(IArticleRepository articleRepository, IUserRepository userRepository, IModelMapper modelMapper)
        {
            this.articleRepository = articleRepository;
            this.userRepository = userRepository;
            this.modelMapper = modelMapper;
        }

        public IActionResult Index()
        {
            List<Article> articles = articleRepository.Top10Articles();
            List<ArticleVM> articleVMs = modelMapper.ArticlesToVMs(articles);
            ViewBag.MostViewed = articleVMs;

            articles = articleRepository.RandomArticles();
            articleVMs = modelMapper.ArticlesToVMs(articles);
            ViewBag.RandomArticles = articleVMs;

            return View();
        }

        public IActionResult Login(string mail = null)
        {
            if (string.IsNullOrEmpty(mail))
            {
                return View(null);
            }

            User user = userRepository.FindUserByMail(mail);

            if (user == null)
            {               
                userRepository.Add(mail);
            }

            string mailUrl = "https://localhost:44398/User/Index/" + "?url=" + user.Url + "&token=" + user.LoginGuid;
            userRepository.SendMail(mail, mailUrl);

            return View("Login", "Email adresinize giriş linki yollandı!");
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
