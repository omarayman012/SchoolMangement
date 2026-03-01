using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class TransCostDto
    {
        [Display(Name = "معرف تكلفة النقل")]
        public int Id { get; set; }

        [Display(Name = "اسم تكلفة النقل")]
        public string? TransCostNm { get; set; }

        [Display(Name = "اسم تكلفة النقل بالإنجليزي")]
        public string? TranscostnmE { get; set; }

        [Display(Name = "قيمة النقل")]
        public decimal? TransportCostValue { get; set; }

        [Display(Name = "نسبة الخصم")]
        public decimal? DiscountPercentage { get; set; }

        [Display(Name = "قيمة النقل الثانية")]
        public decimal? TransportCostValue2 { get; set; }
    }
}
