using System;

namespace BookShop.Model.Models
{
    public  interface IAuditable
    {
        string MetalKeyword { get; set; }
        string MetalDescription { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
        DateTime CreatedBy { get; set; }
        DateTime? UpdatedBy { get; set; }
        bool Status { get; set; }
    }
}
