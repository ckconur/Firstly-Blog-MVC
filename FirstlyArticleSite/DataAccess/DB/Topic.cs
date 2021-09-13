using System;
using System.Collections.Generic;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class Topic
    {
        public Topic()
        {
            Articles = new HashSet<Article>();
            Followings = new HashSet<Following>();
        }

        public int TopicId { get; set; }
        public string TopicName { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Following> Followings { get; set; }
    }
}
