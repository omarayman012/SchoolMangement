using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class AreaDto
    {
        [Display(Name = "معرف المنطقة")]
        public int Id { get; set; }

        [Display(Name = "اسم المنطقة")]
        public string? AreaNm { get; set; }

        [Display(Name = "اسم المنطقة بالإنجليزي")]
        public string? AreaNm_E { get; set; }

        [Display(Name = "المسؤول عن المنطقة")]
        public string? Resp { get; set; }
    }
}
