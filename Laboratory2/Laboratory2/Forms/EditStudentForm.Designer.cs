using System.ComponentModel;

namespace Laboratory2.Forms
{
    partial class EditStudentForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectList = new System.Windows.Forms.DataGridView();
            this.Название = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Баллы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.subjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            label1.Location = new System.Drawing.Point(12, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 23);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            label2.Location = new System.Drawing.Point(12, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 23);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            label3.Location = new System.Drawing.Point(12, 65);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 23);
            label3.TabIndex = 5;
            label3.Text = "Отчество";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.nameTextBox.Location = new System.Drawing.Point(118, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(212, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.surnameTextBox.Location = new System.Drawing.Point(118, 41);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(212, 20);
            this.surnameTextBox.TabIndex = 2;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.patronymicTextBox.Location = new System.Drawing.Point(118, 67);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(212, 20);
            this.patronymicTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Предметы";
            // 
            // subjectList
            // 
            this.subjectList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.subjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Название, this.Баллы});
            this.subjectList.GridColor = System.Drawing.SystemColors.Window;
            this.subjectList.Location = new System.Drawing.Point(12, 129);
            this.subjectList.Name = "subjectList";
            this.subjectList.Size = new System.Drawing.Size(318, 216);
            this.subjectList.TabIndex = 8;
            // 
            // Название
            // 
            this.Название.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            this.Название.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Название.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Название.Width = 210;
            // 
            // Баллы
            // 
            this.Баллы.HeaderText = "Баллы";
            this.Баллы.Name = "Баллы";
            this.Баллы.Width = 60;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(83, 351);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(167, 351);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 378);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.subjectList);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "EditStudentForm";
            this.Text = "Данные студента";
            ((System.ComponentModel.ISupportInitialize) (this.subjectList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;

        private System.Windows.Forms.DataGridView subjectList;
        private System.Windows.Forms.DataGridViewComboBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Баллы;

        private System.Windows.Forms.Label label4;


        private System.Windows.Forms.TextBox nameTextBox;
        
        private System.Windows.Forms.TextBox patronymicTextBox;

        private System.Windows.Forms.TextBox surnameTextBox;

        #endregion
    }
}