﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model.Models
{
    [Table("OrderDetails")]
   public class OrderDetail
    {
        [Key]
     
        public int OrderID { get; set; }
        [Key]
        public int ProductID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("OrderID")]
        public virtual Order Oder { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
