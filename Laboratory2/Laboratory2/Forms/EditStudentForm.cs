using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Laboratory2.Models;
using Laboratory2.Repositories;

namespace Laboratory2.Forms
{
    public partial class EditStudentForm : Form
    {

        private Student _editableStudent = new Student();
        private readonly IStudentsRepository _studentsRepository;
        
        public EditStudentForm(IStudentsRepository studentsRepository, ISubjectsRepository subjectsRepository)
        {
            _studentsRepository = studentsRepository;
            InitializeComponent();

            var subjects = subjectsRepository.All();
            if (subjectList.Columns[0] is DataGridViewComboBoxColumn comboBox)
            {
                comboBox.DataSource = subjects;
                comboBox.DisplayMember = "Name";
                comboBox.ValueMember = "Id";
                comboBox.DataPropertyName = "Id";
            }
        }

        public void SetEditableStudent(Student editableStudent)
        {
            _editableStudent = editableStudent;
            nameTextBox.Text = _editableStudent.Name;
            surnameTextBox.Text = _editableStudent.Surname;
            patronymicTextBox.Text = _editableStudent.Patronymic;
            _editableStudent.SubjectGrades.ForEach(subjectGrade =>
            {
                var index = subjectList.Rows.Add();
                subjectList.Rows[index].Cells[0].Value = subjectGrade.SubjectId;
                subjectList.Rows[index].Cells[1].Value = subjectGrade.Grade.ToString();
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<SubjectGrade> subjectGrades = new List<SubjectGrade>();
            try
            {
                for (int i = 0; i < subjectList.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = subjectList.Rows[i];
                    int subjectId = (int) row.Cells[0].Value;
                    int grade = Convert.ToInt32(row.Cells[1].Value);
                    if (grade < 0 || grade > 100)
                    {
                        return;
                    }
                    subjectGrades.Add(new SubjectGrade(subjectId, grade));
                }
                
            }
            catch (Exception)
            {
                return;
            }

            _editableStudent.SubjectGrades = subjectGrades;
            _editableStudent.Name = nameTextBox.Text;
            _editableStudent.Surname = surnameTextBox.Text;
            _editableStudent.Patronymic = patronymicTextBox.Text;
            _studentsRepository.AddOrUpdate(_editableStudent);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}