using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IStudentService
    {
        IList<Student> GetAll();
        Student GetById(int id);
        void Create(Student stud);
        void Update(Student stud);
        void Delete(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IList<Student> GetAll()
        {
            return _studentRepository
                .GetAll()
                .ToList();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public void Create(Student stud)
        {
            _studentRepository.Create(stud);
        }

        public void Update(Student stud)
        {
            _studentRepository.Update(stud);
        }

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

    }
}
