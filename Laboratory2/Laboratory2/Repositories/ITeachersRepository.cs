using System.Collections.Generic;
using Laboratory2.Models;

namespace Laboratory2.Repositories
{
    public interface ITeachersRepository : IRepository<Teacher>
    {
        List<Teacher> All();

        List<Teacher> BySubjectId(int subjectId);

        Teacher ById(int teacherId);
    }
}