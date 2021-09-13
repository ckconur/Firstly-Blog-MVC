using FirstlyArticleSite.DataAccess.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.DataAccess.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        FirstlyBlogDBContext context;

        public TopicRepository(FirstlyBlogDBContext context)
        {
            this.context = context;
        }


        public List<Topic> GetFollowingTopics(int[] topicIds)
        {
            List<Topic> followedTopics = null;

            if (topicIds.Count() == 0)
                return followedTopics;

            followedTopics = new List<Topic>();

            foreach (int item in topicIds)
            {
                followedTopics.Add(context.Topics.SingleOrDefault(a => a.TopicId == item));
            }

            return followedTopics;
        }

        public List<Topic> GetTopics()
        {
            return context.Topics.ToList();
        }

        public List<Topic> GetUnfollowingTopics(int[] topicIds)
        {
            List<Topic> unfollowedTopics = null;

            if (topicIds.Count() == 0)
                return unfollowedTopics = context.Topics.ToList();

            unfollowedTopics = context.Topics.Where(a => !topicIds.Contains(a.TopicId)).ToList();            

            return unfollowedTopics;
        }
    }
}
