using System.Collections.Generic;

namespace Laboratory2.Models
{
    public class Student : Human
    {
        public int Id { get; set; }
        public List<SubjectGrade> SubjectGrades { get; set; } = new List<SubjectGrade>();

        public Student(string name = "", string surname = "", string patronymic = "", int id = -1) :
            base(name, surname, patronymic)
        {
            Id = id;
        }
    }
}