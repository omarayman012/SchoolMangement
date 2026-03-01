using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class DiscountDto
    {
        [Display(Name = "معرف الخصم")]
        public int? Id { get; set; }

        [Display(Name = "اسم الخصم")]
        public string? DescountNm { get; set; }

        [Display(Name = "اسم الخصم بالإنجليزي")]
        public string? DescountNm_E { get; set; }

        [Display(Name = "قيمة الخصم")]
        public decimal? DiscVal { get; set; }

        [Display(Name = "نسبة الخصم")]
        public decimal? DiscPer { get; set; }

        [Display(Name = "خصم بالقيمة الثانية")]
        public bool DiscVal2 { get; set; }
    }
}
