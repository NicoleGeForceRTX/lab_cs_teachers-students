using System.ComponentModel;

namespace Laboratory2.Forms
{
    partial class SubjectsForm
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
            this.subjectList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize) (this.subjectList)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectList
            // 
            this.subjectList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.subjectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1});
            this.subjectList.GridColor = System.Drawing.SystemColors.Window;
            this.subjectList.Location = new System.Drawing.Point(12, 12);
            this.subjectList.Name = "subjectList";
            this.subjectList.Size = new System.Drawing.Size(417, 426);
            this.subjectList.TabIndex = 0;
            this.subjectList.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.subjectList_UserDeletedRow);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.subjectList);
            this.Name = "SubjectsForm";
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize) (this.subjectList)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

        private System.Windows.Forms.DataGridView subjectList;

        #endregion
    }
}