using System.ComponentModel.DataAnnotations;

namespace StudentProj_EntityFramework
{
    public class Student
    {
        public Student(string name, string specialitate, int year, float average)
        {
            Name = name;
            Department = specialitate;
            Year = year;
            Average = average;
        }

        public Student()
        {
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Department { get; set; }
        public int Year { get; set; }
        public float Average { get; set; }
    }
}