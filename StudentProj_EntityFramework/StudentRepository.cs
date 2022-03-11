using System.Collections.Generic;
using System.Linq;

namespace StudentProj_EntityFramework
{
    public class StudentRepository
    {
        public StudentContext DbContext { get; }

        public StudentRepository(StudentContext context)
        {
            DbContext = context;
        }

        public void Add(Student student)
        {
            DbContext.Students.Add(new Student(student.Name, student.Department, student.Year, student.Average));
            DbContext.SaveChanges();
        }

        public Student Update(Student student)
        {
            var old = Get(student.Id);
            old.Year = student.Year;
            old.Average = student.Average;
            old.Name = student.Name;
            old.Department = student.Department;
            var newStudent = DbContext.Students.Update(old);
            DbContext.SaveChanges();
            return newStudent.Entity;
        }

        public void Remove(int id)
        {
            var student = DbContext.Students.Where(student => student.Id == id).FirstOrDefault();
            DbContext.Students.Remove(student);
            DbContext.SaveChanges();
        }

        public Student Get(int id)
        {
            return DbContext.Students.ToList().Find(x => x.Id == id);
        }

        public IEnumerable<Student> GetAll()
        {
            return DbContext.Students.ToList();
        }
    }
}