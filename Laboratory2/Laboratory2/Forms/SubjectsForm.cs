using System.ComponentModel;
using System.Windows.Forms;
using Laboratory2.Models;
using Laboratory2.Repositories;

namespace Laboratory2.Forms
{
    public partial class SubjectsForm : Form
    {

        private readonly ISubjectsRepository _subjectsRepository;
        private readonly IStudentsRepository _studentsRepository;
        private readonly ITeachersRepository _teachersRepository;

        public SubjectsForm(ISubjectsRepository subjectsRepository, IStudentsRepository studentsRepository, ITeachersRepository teachersRepository)
        {
            _subjectsRepository = subjectsRepository;
            _studentsRepository = studentsRepository;
            _teachersRepository = teachersRepository;
            InitializeComponent();
            
            _subjectsRepository.All().ForEach(subject =>
            {
                var index = subjectList.Rows.Add(subject.Name);
                subjectList.Rows[index].Cells[0].Tag = subject;
            });
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _subjectsRepository.DeleteAll();
            for (int i = 0; i < subjectList.Rows.Count - 1; i++)
            {
                DataGridViewRow row = subjectList.Rows[i];
                if (row.Cells[0].Tag is Subject subject)
                {
                    subject.Name = row.Cells[0].Value.ToString();
                    _subjectsRepository.AddOrUpdate(subject);
                }
                else
                {
                    _subjectsRepository.AddOrUpdate(new Subject(row.Cells[0].Value.ToString()));
                }
            }
            base.OnClosing(e);
        }

        private void subjectList_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.Cells[0].Tag is Subject subject)
            {
                _subjectsRepository.Delete(subject);
                _studentsRepository.BySubjectId(subject.Id).ForEach(student =>
                {
                    int i = 0;
                    while (i < student.SubjectGrades.Count)
                    {
                        if (student.SubjectGrades[i].SubjectId == subject.Id)
                        {
                            student.SubjectGrades.RemoveAt(i);
                        }
                        else
                        {
                            i++;
                        }
                    }
                });
                
                _teachersRepository.BySubjectId(subject.Id).ForEach(teacher =>
                {
                    int i = 0;
                    while (i < teacher.SubjectsId.Count)
                    {
                        if (teacher.SubjectsId[i] == subject.Id)
                        {
                            teacher.SubjectsId.RemoveAt(i);
                        }
                        else
                        {
                            i++;
                        }
                    }
                });
            }
        }
    }
}