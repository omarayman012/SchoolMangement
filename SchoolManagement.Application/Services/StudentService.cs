using Microsoft.EntityFrameworkCore;
using SchoolManagement.Application.DTOs.Student;
using SchoolManagement.Application.ServicesInterfaces;
using SchoolManagement.Domain.Entities;
using SchoolManagement.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddStudentAsync(CreateStudentDto dto)
        {
            var student = new Student
            {
                FullName = dto.FullName
                
            };

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _context.Students
                                 .OrderBy(s => s.FullName)
                                 .ToListAsync();
        }
    }
}
