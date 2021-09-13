using System;
using System.Collections.Generic;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class ArticlePicture
    {
        public int PictureId { get; set; }
        public int ArticleId { get; set; }
        public byte[] Picture { get; set; }

        public virtual Article Article { get; set; }
    }
}
