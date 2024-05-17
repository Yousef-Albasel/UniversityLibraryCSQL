

namespace UniversityLibraryFormsCSQL
{
    partial class DeleteUser
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
            Student = new RadioButton();
            Librarian = new RadioButton();
            user_type = new Label();
            User_id = new Label();
            del_id = new RichTextBox();
            delete_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.BackColor = Color.Transparent;
            Student.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Student.ForeColor = SystemColors.Control;
            Student.Location = new Point(289, 183);
            Student.Name = "Student";
            Student.Size = new Size(78, 23);
            Student.TabIndex = 0;
            Student.TabStop = true;
            Student.Text = "Student";
            Student.UseVisualStyleBackColor = false;
            // 
            // Librarian
            // 
            Librarian.AutoSize = true;
            Librarian.BackColor = Color.Transparent;
            Librarian.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Librarian.ForeColor = SystemColors.Control;
            Librarian.Location = new Point(384, 183);
            Librarian.Name = "Librarian";
            Librarian.Size = new Size(89, 23);
            Librarian.TabIndex = 1;
            Librarian.TabStop = true;
            Librarian.Text = "Librarian";
            Librarian.UseVisualStyleBackColor = false;
            // 
            // user_type
            // 
            user_type.AutoSize = true;
            user_type.BackColor = Color.Transparent;
            user_type.Cursor = Cursors.IBeam;
            user_type.FlatStyle = FlatStyle.Popup;
            user_type.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user_type.ForeColor = SystemColors.Control;
            user_type.Location = new Point(74, 183);
            user_type.Name = "user_type";
            user_type.Size = new Size(109, 27);
            user_type.TabIndex = 2;
            user_type.Text = "User Type";
            // 
            // User_id
            // 
            User_id.AutoSize = true;
            User_id.BackColor = Color.Transparent;
            User_id.Font = new Font("Times New Roman", 18F);
            User_id.ForeColor = SystemColors.Control;
            User_id.Location = new Point(74, 241);
            User_id.Name = "User_id";
            User_id.Size = new Size(87, 27);
            User_id.TabIndex = 3;
            User_id.Text = "User ID";
            // 
            // del_id
            // 
            del_id.Location = new Point(289, 241);
            del_id.Name = "del_id";
            del_id.Size = new Size(184, 27);
            del_id.TabIndex = 4;
            del_id.Text = "";
            // 
            // delete_btn
            // 
            delete_btn.BackColor = SystemColors.Highlight;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = SystemColors.Control;
            delete_btn.Location = new Point(74, 318);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(162, 43);
            delete_btn.TabIndex = 5;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Delete_User;
            pictureBox1.Location = new Point(49, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 496);
            Controls.Add(pictureBox1);
            Controls.Add(delete_btn);
            Controls.Add(del_id);
            Controls.Add(User_id);
            Controls.Add(user_type);
            Controls.Add(Librarian);
            Controls.Add(Student);
            Name = "DeleteUser";
            Text = "Delete User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private RadioButton Student;
        private RadioButton Librarian;
        private Label user_type;
        private Label User_id;
        private RichTextBox del_id;
        private Button delete_btn;
        private PictureBox pictureBox1;
    }
}