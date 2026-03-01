using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class ClassDto
    {
        [Display(Name = "معرف الفصل")]
        public int Id { get; set; }

        [Display(Name = "اسم الفصل")]
        public string? ClassNm { get; set; }

        [Display(Name = "اسم الفصل بالإنجليزي")]
        public string? ClassNmEn { get; set; }

        [Display(Name = "معرف الصف")]
        public int? GradeId { get; set; }

        [Display(Name = "الصف الجديد")]
        public int? NewGradeId { get; set; }

        // Navigation property
        [Display(Name = "الصف")]
        public GradesDto? Grades { get; set; }
    }
}
