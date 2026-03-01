using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.DTOs
{
    public class BankDto
    {
        [Display(Name = "معرف البنك")]
        public int Id { get; set; }

        [Display(Name = "اسم البنك")]
        public string? BankName { get; set; }

        [Display(Name = "اسم البنك بالإنجليزي")]
        public string? BankNameEn { get; set; }

        [Display(Name = "المسؤول")]
        public string? Responsible { get; set; }

    }
}
