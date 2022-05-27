using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Laboratory2.Models;
using Laboratory2.Repositories;

namespace Laboratory2.Forms
{
    public partial class TeachersForm : Form
    {
        private readonly ITeachersRepository _teachersRepository;
        private readonly ISubjectsRepository _subjectRepository;

        private List<Teacher> _teachers;
        
        public TeachersForm(ITeachersRepository teachersRepository, ISubjectsRepository subjectsRepository)
        {
            _teachersRepository = teachersRepository;
            _subjectRepository = subjectsRepository;
            
            InitializeComponent();

            UpdateList();
        }

        private void UpdateList()
        {
            _teachers = _teachersRepository.All();
            teachersList.Items.Clear();
            _teachers.ForEach(teacher =>
            {
                teachersList.Items.Add(new ListViewItem(new[] {teacher.Name, teacher.Surname, teacher.Patronymic}));
            });
            
        }
        
        private void SetEnabledButtons()
        {
            var selectedItem = teachersList.SelectedItems;
            editButton.Enabled = selectedItem.Count == 1 ;
            deleteButton.Enabled = selectedItem.Count > 0;
        }


        private void studentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnabledButtons();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in teachersList.SelectedItems)
            {
                _teachersRepository.Delete(_teachers[item.Index]);
            }
            UpdateList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (teachersList.SelectedItems.Count == 0) return;
            var editableTeacher = _teachers[teachersList.SelectedItems[0].Index];
            var editStudentForm = new EditTeacherForm(_teachersRepository, _subjectRepository);
            editStudentForm.FormClosed += (_, __) => { UpdateList(); };
            editStudentForm.SetEditableStudent(editableTeacher);
            editStudentForm.Show();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var editStudentForm = new EditTeacherForm(_teachersRepository, _subjectRepository);
            editStudentForm.FormClosed += (_, __) => { UpdateList(); };
            editStudentForm.Show();
        }
    }
}