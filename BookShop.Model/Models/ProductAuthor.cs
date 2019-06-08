using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model.Models
{
    [Table("ProductAuthors")]
   public class ProductAuthor
    {[Key,Column(Order =1)]
        public int ProductID { get; set; }
        [Key,Column(Order =2)]
        public int AuthorID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("AuthorID")]
        public virtual Author Author { get; set; }
    }
}
