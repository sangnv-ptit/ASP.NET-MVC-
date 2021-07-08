using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public int ID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Tên")]
        public string FirstName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Họ")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Display(Name = "Xác nhận Mật khẩu")]
        public string ConfirmPassword { get; set; }
        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}