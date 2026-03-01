using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class DriveDto
    {
        [Display(Name = "معرف السائق")]
        public int Id { get; set; }

        [Display(Name = "اسم السائق")]
        public string? DrvNm { get; set; }

        [Display(Name = "اسم السائق بالإنجليزي")]
        public string? DrvNmEn { get; set; }

        [Display(Name = "رقم الموبايل")]
        public string? Mobil { get; set; }

        [Display(Name = "تاريخ انتهاء الرخصة")]
        public string? LicEnd { get; set; }
    }
}
