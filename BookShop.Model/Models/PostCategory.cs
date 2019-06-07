using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model.Models
{
    [Table("PostCategories")]
  public  class PostCategory:TAuditable
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
        [MaxLength(500)]
        public string Desciption { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        [MaxLength(500)]
        public string Image { get; set; }
        public bool? HomeFlag { get; set;}
        public IEnumerable<Post> Posts { get; set; }
     
    }
}
