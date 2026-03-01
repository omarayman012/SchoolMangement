using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class SchoolDto
    {
        [Display(Name = "معرف المدرسة")]
        public int Id { get; set; }

        [Display(Name = "اسم المدرسة")]
        public string? SchoolNm { get; set; }

        [Display(Name = "اسم المدرسة بالإنجليزي")]
        public string? SchoolNmEn { get; set; }
    }
}
