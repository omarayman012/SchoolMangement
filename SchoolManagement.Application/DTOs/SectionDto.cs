using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class SectionDto
    {
        [Display(Name = "معرف القسم")]
        public int Id { get; set; }

        [Display(Name = "اسم القسم")]
        public string? SectionName { get; set; }

        [Display(Name = "اسم القسم بالإنجليزي")]
        public string? SectionNameEn { get; set; }
    }
}
