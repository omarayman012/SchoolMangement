using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    internal class BranchDto
    {
        [Display(Name = "معرف الفرع")]
        public int Id { get; set; }

        [Display(Name = "اسم الفرع")]
        public string? BRNNM { get; set; }

        [Display(Name = "اسم الفرع بالإنجليزي")]
        public string? BRNNM_E { get; set; }

        [Display(Name = "المسؤول عن الفرع")]
        public string? RESP { get; set; }
    }
}
