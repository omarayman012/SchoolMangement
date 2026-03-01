using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class StudentStatusDto
    {
        [Display(Name = "معرف حالة الطالب")]
        public int Id { get; set; }

        [Display(Name = "اسم الحالة")]
        public string? StatusName { get; set; }

        [Display(Name = "اسم الحالة بالإنجليزي")]
        public string? StatusNameEn { get; set; }
    }
}
