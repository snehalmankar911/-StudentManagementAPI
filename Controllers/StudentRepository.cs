using StudentManagementAPI.Data;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public Student Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }

        public bool Delete(int id)
        {
            var data = _context.Students.Find(id);
            if (data == null) return false;

            _context.Students.Remove(data);
            _context.SaveChanges();
            return true;
        }
    }
}