using System.ComponentModel;

namespace Laboratory2.Forms
{
    partial class StudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.studentsList = new System.Windows.Forms.ListView();
            this.surname = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.patronymic = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(624, 12);
            this.newButton.Name = "newButton";
            this.newButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newButton.Size = new System.Drawing.Size(164, 23);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "Добавить";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(624, 41);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(164, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(624, 70);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteButton.Size = new System.Drawing.Size(164, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // studentsList
            // 
            this.studentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.surname, this.name, this.patronymic});
            this.studentsList.FullRowSelect = true;
            this.studentsList.Location = new System.Drawing.Point(12, 12);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(606, 426);
            this.studentsList.TabIndex = 5;
            this.studentsList.UseCompatibleStateImageBehavior = false;
            this.studentsList.View = System.Windows.Forms.View.Details;
            this.studentsList.SelectedIndexChanged += new System.EventHandler(this.studentsList_SelectedIndexChanged);
            this.studentsList.DoubleClick += new System.EventHandler(this.editButton_Click);
            // 
            // surname
            // 
            this.surname.Text = "Фамилия";
            this.surname.Width = 156;
            // 
            // name
            // 
            this.name.Text = "Имя";
            this.name.Width = 175;
            // 
            // patronymic
            // 
            this.patronymic.Text = "Отчество";
            this.patronymic.Width = 231;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "StudentsForm";
            this.Text = "Студенты";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader patronymic;

        private System.Windows.Forms.ListView studentsList;

        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;

        #endregion
    }
}