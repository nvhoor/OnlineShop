using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model.Models
{
    [Table("Menus")]
  public  class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { set; get; }
        [Required]
        [MaxLength(500)]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }
        public int GroupID { get; set; }
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
        [MaxLength(10),Column(TypeName ="VARCHAR")]
        public string Target { get; set; }
        public bool Status { get; set; }
    }
}
