using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebook.Models
{
    public class ProductDetailModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Product Name Required")]
        public string ProductName { get; set; }

        [Required]
        [Range(1,50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<System.DateTime> Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }

        [Required]
        [Range(typeof(int), "1","100",ErrorMessage ="Quantity is invalid")]
        public Nullable<int> Quantity { get; set; }

        [Required]
        [Range(typeof(decimal),"1","5000",ErrorMessage ="Price range is invalid")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }

    }
}