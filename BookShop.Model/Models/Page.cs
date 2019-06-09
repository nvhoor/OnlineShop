using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model.Models
{
    [Table("Pages")]
  public  class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250), Column(TypeName = "VARCHAR")]
        public string Alias { get; set; }
        public string Content { get; set; }
        [MaxLength(250)]
        public string MetalKeyword { get; set; }
        [MaxLength(250)]
        public string MetalDescription { get; set; }
       
        public bool Status { get; set; }

    }
}
