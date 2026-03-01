using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class StudyYearDto
    {
        [Display(Name = "معرف السنة الدراسية")]
        public int Id { get; set; }

        [Display(Name = "اسم السنة الدراسية")]
        public string? StudyYearsNm { get; set; }

        [Display(Name = "اسم السنة الدراسية بالإنجليزي")]
        public string? StudyYearsNm_E { get; set; }

        [Display(Name = "تاريخ البداية")]
        public DateTime? FromDate { get; set; }

        [Display(Name = "تاريخ النهاية")]
        public DateTime? ToDate { get; set; }

        [Display(Name = "هل السنة مغلقة؟")]
        public bool IsClosed { get; set; }

        [Display(Name = "هل سنة جديدة؟")]
        public bool IsNewYear { get; set; }

        [Display(Name = "السنة الافتراضية؟")]
        public bool IsDefault { get; set; }
    }
}
