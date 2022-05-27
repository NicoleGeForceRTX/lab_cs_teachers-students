using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Laboratory2.Models;
using Laboratory2.Repositories;

namespace Laboratory2.Forms
{
    public partial class StudentsForm : Form
    {
        private readonly IStudentsRepository _studentsRepository;
        private readonly ISubjectsRepository _subjectRepository;

        private List<Student> _students;

        public StudentsForm(IStudentsRepository studentsRepository, ISubjectsRepository subjectsRepository)
        {
            _studentsRepository = studentsRepository;
            _subjectRepository = subjectsRepository;

            InitializeComponent();

            UpdateList();
            SetEnabledButtons();
        }

        private void UpdateList()
        {
            studentsList.Items.Clear();
            _students = _studentsRepository.All();
            _students.ForEach(student =>
            {
                studentsList.Items.Add(new ListViewItem(new[] {student.Name, student.Surname, student.Patronymic}));
            });
        }

        private void SetEnabledButtons()
        {
            var selectedItem = studentsList.SelectedItems;
            editButton.Enabled = selectedItem.Count == 1 ;
            deleteButton.Enabled = selectedItem.Count > 0;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var editStudentForm = new EditStudentForm(_studentsRepository, _subjectRepository);
            editStudentForm.FormClosed += (_, __) => { UpdateList(); };
            editStudentForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in studentsList.SelectedItems)
            {
                _studentsRepository.Delete(_students[item.Index]);
            }
            UpdateList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (studentsList.SelectedItems.Count == 0) return;
            var editableStudent = _students[studentsList.SelectedItems[0].Index];
            var editStudentForm = new EditStudentForm(_studentsRepository, _subjectRepository);
            editStudentForm.FormClosed += (_, __) => { UpdateList(); };
            editStudentForm.SetEditableStudent(editableStudent);
            editStudentForm.Show();
        }

        private void studentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnabledButtons();
        }
    }
}