using System;
using System.Collections.Generic;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class LikedArticle
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }
        public virtual User User { get; set; }
    }
}
