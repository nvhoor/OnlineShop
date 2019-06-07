using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model.Models
{
    [Table("PostTags")]
   public class PostTag
    {
        [Key]
        public int PostID { get; set; }
        [Key,MaxLength(50), Column(TypeName = "VARCHAR")]
        public int TagID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
