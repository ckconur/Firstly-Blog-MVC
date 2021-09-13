using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstlyArticleSite.DataAccess.DB;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public interface IFollowingRepository
    {
        int[] FindFollowedTopicIDs(int? userId);

        bool AddFollowing(Following following);

        bool DeleteFollowing(Following following);

    }
}
