using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ebook.Models
{
    public class CategoryDetailModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Category Name Required")]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}