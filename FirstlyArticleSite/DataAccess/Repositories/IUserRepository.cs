using FirstlyArticleSite.DataAccess.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public interface IUserRepository
    {
        void Add(string mail);
        void Add(User user);

        User FindUserByMail(string mail);

        User FindUserByURL(string url);

        User GetUser(int? id);

        string GetBase64StringProfilePicture(int? id);

        bool Update(User user);

        bool UpdatePP(ProfilePicture pp);

        void UpdateUserToken(User user);

        bool DeleteUser(int? id);

        void SendMail(string mail, string url);
    }
}
