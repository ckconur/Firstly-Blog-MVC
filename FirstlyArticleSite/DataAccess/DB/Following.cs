using System;
using System.Collections.Generic;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class Following
    {
        public int UserId { get; set; }
        public int TopicId { get; set; }
        public int FollowingId { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual User User { get; set; }
    }
}
