using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstlyArticleSite.DataAccess.DB;


namespace FirstlyArticleSite.DataAccess.Repositories
{
    public class FollowingRepository : IFollowingRepository
    {
        FirstlyBlogDBContext context;
        public FollowingRepository(FirstlyBlogDBContext context)
        {
            this.context = context;
        }

        public int[] FindFollowedTopicIDs(int? userId)
        {
            int[] topicIds = context.Followings.Where(a => a.UserId == userId).Select(a => a.TopicId).ToArray();

            return topicIds;
        }

        public bool DeleteFollowing(Following following)
        {
            Following flw = context.Followings.Single(a => a.UserId == following.UserId && a.TopicId == following.TopicId);
            context.Followings.Remove(flw);
            int result = context.SaveChanges();

            if (result > 0)
                return true;
            else
                return false;
        }

        public bool AddFollowing(Following following)
        {
            context.Followings.Add(following);
            int result = context.SaveChanges();

            if (result > 0)
                return true;
            else
                return false;
        }
    }
}
