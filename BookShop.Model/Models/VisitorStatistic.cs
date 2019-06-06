using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model.Models
{
    [Table("VisitorStatistics")]
    public  class VisitorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public DateTime VistedDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string IPAdress { get; set; } 
    }
}
