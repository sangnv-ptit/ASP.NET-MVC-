using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }
        [StringLength(500, MinimumLength = 3)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}