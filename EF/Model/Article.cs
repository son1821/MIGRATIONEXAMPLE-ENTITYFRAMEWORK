using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1.Model
{
    [Table("article")]
    public class Article
    {
        
      
        
            [Key]
            public int ArticleId { set; get; }

            [StringLength(100)]
            public string Name { set; get; }

        [Column(TypeName = "ntext")]
        public string Content { set; get; }
      }
}
