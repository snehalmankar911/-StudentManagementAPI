using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;

namespace StudentManagementAPI.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetAll()
        {
            return _repo.GetAll();
        }

        public Student Add(Student student)
        {
            student.CreatedDate = DateTime.Now;
            return _repo.Add(student);
        }

        public Student Update(int id, Student student)
        {
            var data = _repo.GetById(id);
            if (data == null) return null;

            data.Name = student.Name;
            data.Email = student.Email;
            data.Age = student.Age;
            data.Course = student.Course;

            return _repo.Update(data);
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}