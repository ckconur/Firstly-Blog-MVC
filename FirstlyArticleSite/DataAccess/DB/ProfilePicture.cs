using System;
using System.Collections.Generic;

#nullable disable

namespace FirstlyArticleSite.DataAccess.DB
{
    public partial class ProfilePicture
    {
        public int PictureId { get; set; }
        public int UserId { get; set; }
        public byte[] Picture { get; set; }

        public virtual User User { get; set; }
    }
}
