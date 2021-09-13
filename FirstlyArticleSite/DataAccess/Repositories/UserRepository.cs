using FirstlyArticleSite.DataAccess.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;


namespace FirstlyArticleSite.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        FirstlyBlogDBContext context;
        public UserRepository(FirstlyBlogDBContext context)
        {
            this.context = context;
        }

        public void Add(string mail)
        {
            User user = new User()
            {
                UserName = mail.Split('@')[0],
                Email = mail,
                Url = $"{mail.Split('@')[0]}",
                LoginGuid = Guid.NewGuid().ToString()
            };


            Add(user);
        }

        public void Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public bool Update(User user)
        {

            User oldUser = context.Users.SingleOrDefault(a => a.UserId == user.UserId);
            oldUser.FirstName = user.FirstName;
            oldUser.LastName = user.LastName;
            oldUser.UserName = user.UserName;
            oldUser.Email = user.Email;
            oldUser.AboutMe = user.AboutMe;
            oldUser.Url = user.Url;
            int result = context.SaveChanges();

            if (result > 0)
            {
                return true; 
            }
            return false;
        }
        public bool UpdatePP(ProfilePicture pp)
        {
            ProfilePicture newPP = context.ProfilePictures.SingleOrDefault(a => a.UserId == pp.UserId);

            if (newPP != null)
            {
                newPP.Picture = pp.Picture;
            }
            else
            {
                newPP = new ProfilePicture()
                {
                    UserId = pp.UserId,
                    Picture = pp.Picture                    
                };
                context.ProfilePictures.Add(newPP);
                return context.SaveChanges() > 0;
            }

            context.SaveChanges();

            return true;
        }
        public User GetUser(int? id)
        {
            return context.Users.Find(id);
        }

        public string GetBase64StringProfilePicture(int? id)
        {
            ProfilePicture pp = context.ProfilePictures.SingleOrDefault(a => a.UserId == id);

            if (pp != null)
            {
                string base64pp = "data:image/png;base64," + Convert.ToBase64String(pp.Picture, 0, pp.Picture.Length); 
                return base64pp;
            }

            return null;
        }
        public bool DeleteUser(int? id)
        {
            List<Article> articles = context.Articles.Where(a => a.WriterId == id).ToList();
            List<ProfilePicture> profilePictures = context.ProfilePictures.Where(a => a.UserId == id).ToList();
            List<Following> followings = context.Followings.Where(a => a.UserId == id).ToList();
            List<SavedArticle> savedArticles = context.SavedArticles.Where(a => a.UserId == id).ToList();

            context.Articles.RemoveRange(articles);
            context.ProfilePictures.RemoveRange(profilePictures);
            context.Followings.RemoveRange(followings);
            context.SavedArticles.RemoveRange(savedArticles);

            User user = GetUser(id);
            context.Users.Remove(user);
            int result = context.SaveChanges();

            if (result > 0)
                return true;

            else
                return false;
        }

        public User FindUserByMail(string mail)
        {
            User user = context.Users.SingleOrDefault(a => a.Email == mail);

            return user;
        }

        public User FindUserByURL(string url)
        {
            return context.Users.SingleOrDefault(a => a.Url == url);
        }

        public void UpdateUserToken(User user)
        {
            User user1 = context.Users.SingleOrDefault(a => a.UserId == user.UserId);
            user1.LoginGuid = Guid.NewGuid().ToString();
            int result = context.SaveChanges();
        }
        
        void IUserRepository.SendMail(string mail, string url)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("aubrey.homenick@ethereal.email"));
            email.To.Add(MailboxAddress.Parse(mail));
            email.Subject = "Login";
            email.Body = new TextPart(TextFormat.Html) { Text = $"<a href='{url}'>Giriş Yapmak İçin Tıklayınız</a>" };

            using var smtp = new SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.Auto);
            smtp.Authenticate("aubrey.homenick@ethereal.email", "65J5rF8Ym4gbUPNvMh");
            smtp.Send(email);
            smtp.Disconnect(true);
        }

    }
}
