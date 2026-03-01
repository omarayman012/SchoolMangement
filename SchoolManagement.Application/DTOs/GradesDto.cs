using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class GradesDto
    {
        public int Id { get; set; }

        [Display(Name = "اسم الطالب")]
        public string? FullName { get; set; }

        [Display(Name = "الاسم الإنجليزي")]
        public string? EnglishName { get; set; }

        [Display(Name = "نوع الخصم")]
        public int? Discounttypeid { get; set; }
        [Display(Name = "نوع الانتقال")]
        public int? TransferTypeId { get; set; }

        [Display(Name = "الجنس")]
        public string? StudentSex { get; set; }

        [Display(Name = "المرحلة")]
        public int? StagesId { get; set; }
        [Display(Name = "الصف")]
        public int? GradesId { get; set; }

        [Display(Name = "الصف")]
        public GradesDto? Grades { get; set; }

        [Display(Name = "القسم")]
        public int? SectionId { get; set; }

        [Display(Name = "القسم")]

        public int? SchoolId { get; set; }



    }
}
