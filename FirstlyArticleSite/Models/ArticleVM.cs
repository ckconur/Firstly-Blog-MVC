using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstlyArticleSite.Models
{
    public class ArticleVM
    {
        private string base64HeaderImage;
        private byte[] headerImage;

        public int ArticleId { get; set; }
        public int WriterId { get; set; }
        public int TopicId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }
        public int ViewCount { get; set; }
        public byte[] HeaderImage
        {

            get { return headerImage; }
            set
            {
                headerImage = value;
                base64HeaderImage = "data:image/png;base64," + Convert.ToBase64String(headerImage, 0, headerImage.Length);
            }
        }

        public string Base64HeaderImage { get { return base64HeaderImage; } set { base64HeaderImage = value; } }

        public decimal AvarageReadingTime { get; set; }

    }
}
