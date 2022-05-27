using System.ComponentModel;

namespace Laboratory2.Forms
{
    partial class TeachersForm
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
            this.teachersList = new System.Windows.Forms.ListView();
            this.surname = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.patronymic = new System.Windows.Forms.ColumnHeader();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teachersList
            // 
            this.teachersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.surname, this.name, this.patronymic});
            this.teachersList.FullRowSelect = true;
            this.teachersList.Location = new System.Drawing.Point(12, 12);
            this.teachersList.Name = "teachersList";
            this.teachersList.Size = new System.Drawing.Size(606, 426);
            this.teachersList.TabIndex = 9;
            this.teachersList.UseCompatibleStateImageBehavior = false;
            this.teachersList.View = System.Windows.Forms.View.Details;
            this.teachersList.SelectedIndexChanged += new System.EventHandler(this.studentsList_SelectedIndexChanged);
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
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(624, 70);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteButton.Size = new System.Drawing.Size(164, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(624, 41);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(164, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(624, 12);
            this.newButton.Name = "newButton";
            this.newButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newButton.Size = new System.Drawing.Size(164, 23);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "Добавить";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.teachersList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Name = "TeachersForm";
            this.Text = "Teachers";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView teachersList;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader patronymic;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newButton;

        #endregion
    }
}