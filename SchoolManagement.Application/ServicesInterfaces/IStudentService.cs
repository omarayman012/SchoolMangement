using SchoolManagement.Application.DTOs.Student;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.ServicesInterfaces
{
    public interface IStudentService
    {
        Task AddStudentAsync(CreateStudentDto dto);

        Task<List<Student>> GetAllStudentsAsync(); 

    }
}
