using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class StagesDto
    {
        [Display(Name = "معرف المرحلة")]
        public int Id { get; set; }

        [Display(Name = "اسم المرحلة")]
        public string? StageNM { get; set; }

        [Display(Name = "اسم المرحلة بالإنجليزي")]
        public string? StageNM_E { get; set; }
    }
}
