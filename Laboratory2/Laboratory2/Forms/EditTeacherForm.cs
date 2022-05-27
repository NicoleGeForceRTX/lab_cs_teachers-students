using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Laboratory2.Models;
using Laboratory2.Repositories;

namespace Laboratory2.Forms
{
    public partial class EditTeacherForm : Form
    {
        
        private readonly ITeachersRepository _teachersRepository;

        private Teacher _editableTeacher = new Teacher();

        public EditTeacherForm(ITeachersRepository teachersRepository, ISubjectsRepository subjectsRepository)
        {
            _teachersRepository = teachersRepository;
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
        
        public void SetEditableStudent(Teacher editableTeacher)
        {
            _editableTeacher = editableTeacher;
            nameTextBox.Text = _editableTeacher.Name;
            surnameTextBox.Text = _editableTeacher.Surname;
            patronymicTextBox.Text = _editableTeacher.Patronymic;
            _editableTeacher.SubjectsId.ForEach(subjectId =>
            {
                var index = subjectList.Rows.Add();
                subjectList.Rows[index].Cells[0].Value = subjectId;
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            List<int> subjectsId = new List<int>();
            try
            {
                for (int i = 0; i < subjectList.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = subjectList.Rows[i];
                    subjectsId.Add((int) row.Cells[0].Value);
                }
            }
            catch (Exception)
            {
                return;
            }

            _editableTeacher.Name = nameTextBox.Text;
            _editableTeacher.Surname = surnameTextBox.Text;
            _editableTeacher.Patronymic = patronymicTextBox.Text;
            _editableTeacher.SubjectsId = subjectsId;
            _teachersRepository.AddOrUpdate(_editableTeacher);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}