using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstlyArticleSite.DataAccess.Repositories;
using FirstlyArticleSite.DataAccess.DB;
using FirstlyArticleSite.Models;


namespace FirstlyArticleSite.Controllers
{
    public class WriterController : Controller
    {
        IUserRepository userRepository;
        IArticleRepository articleRepository;
        IModelMapper modelMapper;
        public WriterController(IUserRepository userRepository, IArticleRepository articleRepository, IModelMapper modelMapper)
        {
            this.userRepository = userRepository;
            this.articleRepository = articleRepository;
            this.modelMapper = modelMapper;
        }

        public IActionResult Detail(string url = null)
        {
            if (url != null)
            {
                User user = userRepository.FindUserByURL(url);

                UserVM userVM = modelMapper.UserToVM(user, userRepository.GetBase64StringProfilePicture(user.UserId));

                return View(userVM);
            }

            return Json("kullanıcı bulunamadı");
        }

        [HttpGet]
        public IActionResult WriterArticles(int? id = null)
        {
            if (id != null)
            {
                List<Article> articles = articleRepository.GetWriterArticles(id);
                List<ArticleVM> articleVMs = modelMapper.ArticlesToVMs(articles);
                
                return PartialView("_WriterArticles", articleVMs);
            }

            return Json("Kullanıcıya ait makale bulunamadı!");
        }
    }
}
