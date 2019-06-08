﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model.Models
{
    [Table("Tags")]
   public class Tag
    {
        [Key]
        [MaxLength(50),Column(TypeName ="VARCHAR")]
        public string ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(50), Column(TypeName = "VARCHAR")]
        public string Type { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set;}
    }
}