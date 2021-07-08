using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [StringLength(500, MinimumLength = 3)]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0} VNĐ")]
        [Display(Name = "Giá")]
        public double Price { get; set; }
        [Display(Name = "Mới")]
        public bool IsNew { get; set; }
        [Display(Name = "Bán chạy")]
        public bool IsSale { get; set; }
        [Display(Name = "Ảnh")]
        public string Image { get; set; }
        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}