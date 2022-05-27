namespace Laboratory2.Forms
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.studentsButton = new System.Windows.Forms.Button();
            this.subjectsButton = new System.Windows.Forms.Button();
            this.teachersButton = new System.Windows.Forms.Button();
            this.studentsRatingButton = new System.Windows.Forms.Button();
            this.teachersRatingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsButton
            // 
            this.studentsButton.Location = new System.Drawing.Point(82, 119);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(156, 23);
            this.studentsButton.TabIndex = 0;
            this.studentsButton.Text = "Студенты";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.studentsButton_Click);
            // 
            // subjectsButton
            // 
            this.subjectsButton.Location = new System.Drawing.Point(82, 148);
            this.subjectsButton.Name = "subjectsButton";
            this.subjectsButton.Size = new System.Drawing.Size(156, 23);
            this.subjectsButton.TabIndex = 1;
            this.subjectsButton.Text = "Предметы";
            this.subjectsButton.UseVisualStyleBackColor = true;
            this.subjectsButton.Click += new System.EventHandler(this.subjectsButton_Click);
            // 
            // teachersButton
            // 
            this.teachersButton.Location = new System.Drawing.Point(82, 177);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(156, 23);
            this.teachersButton.TabIndex = 2;
            this.teachersButton.Text = "Преподаватели";
            this.teachersButton.UseVisualStyleBackColor = true;
            this.teachersButton.Click += new System.EventHandler(this.teachersButton_Click);
            // 
            // studentsRatingButton
            // 
            this.studentsRatingButton.Location = new System.Drawing.Point(82, 234);
            this.studentsRatingButton.Name = "studentsRatingButton";
            this.studentsRatingButton.Size = new System.Drawing.Size(156, 23);
            this.studentsRatingButton.TabIndex = 3;
            this.studentsRatingButton.Text = "Рейтинг студентов";
            this.studentsRatingButton.UseVisualStyleBackColor = true;
            this.studentsRatingButton.Click += new System.EventHandler(this.studentsRatingButton_Click);
            // 
            // teachersRatingButton
            // 
            this.teachersRatingButton.Location = new System.Drawing.Point(82, 263);
            this.teachersRatingButton.Name = "teachersRatingButton";
            this.teachersRatingButton.Size = new System.Drawing.Size(156, 23);
            this.teachersRatingButton.TabIndex = 4;
            this.teachersRatingButton.Text = "Рейтинг преподавателей";
            this.teachersRatingButton.UseVisualStyleBackColor = true;
            this.teachersRatingButton.Click += new System.EventHandler(this.teachersRatingButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 446);
            this.Controls.Add(this.teachersRatingButton);
            this.Controls.Add(this.studentsRatingButton);
            this.Controls.Add(this.teachersButton);
            this.Controls.Add(this.subjectsButton);
            this.Controls.Add(this.studentsButton);
            this.Name = "HomeForm";
            this.Text = "Laboratory2";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button teachersRatingButton;

        private System.Windows.Forms.Button studentsRatingButton;

        private System.Windows.Forms.Button subjectsButton;
        private System.Windows.Forms.Button studentsButton;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.Button teachersButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        #endregion
    }
}