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
        [Key]
        public int TagID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Posts { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tags { get; set; }
    }
}
