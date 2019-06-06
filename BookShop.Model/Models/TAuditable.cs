using System;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Model.Models
{
    class TAuditable : IAuditable
    {
        [MaxLength(50)]
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
        [MaxLength(50)]
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
