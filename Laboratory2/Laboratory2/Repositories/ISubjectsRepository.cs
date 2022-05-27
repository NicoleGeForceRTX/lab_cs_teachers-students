using System.Collections.Generic;
using Laboratory2.Models;

namespace Laboratory2.Repositories
{
    public interface ISubjectsRepository : IRepository<Subject>
    {
        List<Subject> All();

        Subject ById(int subjectId);
    }
}