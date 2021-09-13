using FirstlyArticleSite.DataAccess.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public interface ITopicRepository
    {
        List<Topic> GetTopics();

        List<Topic> GetFollowingTopics(int[] topicIds);

        List<Topic> GetUnfollowingTopics(int[] topicIds);
    }
}
