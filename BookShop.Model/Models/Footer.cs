using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model.Models
{
    [Table("Footers")]
  public  class Footer
    {
        [Key]
        [MaxLength(50),Column(TypeName ="VARCHAR")]
        public string ID { set; get; }
        public string Content { get; set; }
    }
}
