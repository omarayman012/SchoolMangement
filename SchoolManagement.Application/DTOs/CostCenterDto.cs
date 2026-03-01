using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class CostCenterDto
    {
        [Display(Name = "معرف مركز التكلفة")]
        public int Id { get; set; }

        [Display(Name = "اسم مركز التكلفة")]
        public string? CostNm { get; set; }

        [Display(Name = "اسم مركز التكلفة بالإنجليزي")]
        public string? CostNme { get; set; }

        [Display(Name = "ملاحظات")]
        public string? Notes { get; set; }
    }
}
