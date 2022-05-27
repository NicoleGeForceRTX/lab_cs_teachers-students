using System;
using System.Windows.Forms;
using Laboratory2.Repositories;

namespace Laboratory2.Forms
{
    public partial class HomeForm : Form
    {

        private readonly IStudentsRepository _studentsRepository;
        private readonly ITeachersRepository _teachersRepository;
        private readonly ISubjectsRepository _subjectsRepository;
        private readonly Ratings _ratings;
        
        public HomeForm(IStudentsRepository studentsRepository, ITeachersRepository teachersRepository, ISubjectsRepository subjectsRepository)
        {
            _studentsRepository = studentsRepository;
            _teachersRepository = teachersRepository;
            _subjectsRepository = subjectsRepository;
            _ratings = new Ratings(_studentsRepository, _teachersRepository);
            InitializeComponent();
        }

        private void studentsButton_Click(object sender, EventArgs e)
        {
            new StudentsForm(_studentsRepository, _subjectsRepository).Show();
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            new TeachersForm(_teachersRepository, _subjectsRepository).Show();
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            new SubjectsForm(_subjectsRepository, _studentsRepository, _teachersRepository).Show();
        }

        private void studentsRatingButton_Click(object sender, EventArgs e)
        {
            new RatingForm(_ratings.StudentsRating()).Show();
        }

        private void teachersRatingButton_Click(object sender, EventArgs e)
        {
            new RatingForm(_ratings.TeacherRating()).Show();
        }
    }
}