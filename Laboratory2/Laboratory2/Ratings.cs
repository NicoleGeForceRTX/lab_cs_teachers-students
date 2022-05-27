using System.Collections.Generic;
using System.Linq;
using Laboratory2.Models;
using Laboratory2.Repositories;

namespace Laboratory2
{
    public class Ratings
    {

        private readonly IStudentsRepository _studentsRepository;
        private readonly ITeachersRepository _teachersRepository;

        public Ratings(IStudentsRepository studentsRepository, ITeachersRepository teachersRepository)
        {
            _teachersRepository = teachersRepository;
            _studentsRepository = studentsRepository;
        }
        
        public List<Result> StudentsRating()
        {
            var rating = new List<Result>();
            _studentsRepository.All().ForEach(student =>
            {
                int gpa; 
                if (student.SubjectGrades.Count == 0)
                {
                    gpa = 0;
                }
                else
                {
                    gpa = student.SubjectGrades.Sum(subjectGrade => subjectGrade.Grade) / student.SubjectGrades.Count;                    
                }
                rating.Add(new Result(student, gpa));
            });
            rating.Sort((sr1, sr2) => sr2.Gpa - sr1.Gpa);
            return rating;
        }

        public List<Result> TeacherRating()
        {
            var rating = new List<Result>();
            _teachersRepository.All().ForEach(teacher => // Проходим каждого учителя 
            {
                int sum = 0;
                int count = 0;
                teacher.SubjectsId.ForEach(subjectId => // Проходим по каждому преподаваемому предмету
                {
                    _studentsRepository.BySubjectId(subjectId).ForEach(student => // Ищем студентов, у которых есть такой предмет 
                    {
                        var iterator = student.SubjectGrades
                            .Where(subjectGrade => subjectGrade.SubjectId == subjectId).GetEnumerator();
                        // Ищем у студента оценку по этому предмету
                        while (iterator.MoveNext())
                        {
                            sum += iterator.Current.Grade;
                            count++;
                        }
                        iterator.Dispose();
                    });
                });
                int gpa;
                if (count == 0)
                {
                    gpa = 0;
                }
                else
                {
                    gpa = sum / count;
                }
                rating.Add(new Result(teacher, gpa));
            });
            
            rating.Sort((tr1, tr2) => tr2.Gpa - tr1.Gpa);
            return rating;
        }
    }
}