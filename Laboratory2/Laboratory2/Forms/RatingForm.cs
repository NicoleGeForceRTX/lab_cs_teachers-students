using System.Collections.Generic;
using System.Windows.Forms;
using Laboratory2.Models;

namespace Laboratory2.Forms
{
    public partial class RatingForm : Form
    {
        
        public RatingForm(List<Result> studentsRating)
        {
            InitializeComponent();

            for (int i = 0; i < studentsRating.Count; i++)
            {
                var human = studentsRating[i].Human;
                studentsList.Items.Add(new ListViewItem(new[]
                {
                    (i + 1).ToString(),
                    human.Surname,
                    human.Name,
                    human.Patronymic,
                    studentsRating[i].Gpa.ToString()
                }));
            }
        }
    }
}