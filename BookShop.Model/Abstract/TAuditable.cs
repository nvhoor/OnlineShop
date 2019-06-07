using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Model.Models
{
  public abstract  class TAuditable : IAuditable
    {
        [MaxLength(50), Column(TypeName = "VARCHAR")]
        public DateTime CreatedBy
        {
            get;

            set;
        }

        public DateTime CreatedDate
        {
            get;


            set;

        }
        [MaxLength(250)]
        public string MetalDescription
        {
            get
          ;

            set
           ;
        }
        [MaxLength(250)]
        public string MetalKeyword
        {
            get
           ;

            set
           ;
        }
        [Required]
        public bool Status
        {
            get
            ;
            set
           ;
        }
        [MaxLength(50), Column(TypeName = "VARCHAR")]
        public DateTime? UpdatedBy
        {
            get
           ;

            set
           ;
        }

        public DateTime? UpdatedDate
        {
            get
           ;

            set
            ;
        }
    }
}
