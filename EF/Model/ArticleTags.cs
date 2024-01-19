using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1.Model
{
    public class ArticleTags
    {
        [Key]
        public int ArticleTagsId { get; set; }

        public int ArticleId { get; set; }

        [ForeignKey("ArticleId")]
        public Article article { get; set; }

        public int TagId { get; set; }
        [ForeignKey("TagId")]
        public Tag tag { get; set; }

        
    }
}
