using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookShop.Model.Models
{
    [Table("Products")]
   public class Product:TAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250), Column(TypeName = "VARCHAR")]
        public string Alias { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
        public int PublisherID { get; set; }
        [ForeignKey("PublisherID")]
        public virtual Publisher Publisher { get; set; }
        [MaxLength(500)]
        public string Image { get; set; }
        [Column(TypeName ="xml")]
        public string MoreImages { get; set; }
        public int? PageNumber { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        [MaxLength(500)]
        public string Desciption { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
       public virtual IEnumerable<ProductTag> ProductTags { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
        public virtual IEnumerable<ProductAuthor> ProductAuthors { get; set; }
    }
}
