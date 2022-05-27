using System.Collections.Generic;
using Laboratory2.Models;

namespace Laboratory2.Repositories
{
    public interface IStudentsRepository : IRepository<Student>
    {
        List<Student> All();

        List<Student> BySubjectId(int subjectId);

        Student ById(int studentId);
    }
}