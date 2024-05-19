

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUser));
            Student = new RadioButton();
            Librarian = new RadioButton();
            user_type = new Label();
            User_id = new Label();
            del_id = new RichTextBox();
            delete_btn = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            metroControlBox4 = new ReaLTaiizor.Controls.MetroControlBox();
            metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            metroControlBox2 = new ReaLTaiizor.Controls.MetroControlBox();
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.BackColor = Color.Transparent;
            Student.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            Student.ForeColor = SystemColors.Control;
            Student.Location = new Point(265, 115);
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
            Librarian.Location = new Point(360, 115);
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
            user_type.Location = new Point(50, 115);
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
            User_id.Location = new Point(50, 173);
            User_id.Name = "User_id";
            User_id.Size = new Size(87, 27);
            User_id.TabIndex = 3;
            User_id.Text = "User ID";
            // 
            // del_id
            // 
            del_id.Location = new Point(265, 173);
            del_id.Name = "del_id";
            del_id.Size = new Size(184, 27);
            del_id.TabIndex = 4;
            del_id.Text = "";
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.DarkOrchid;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_btn.ForeColor = SystemColors.Control;
            delete_btn.Location = new Point(546, 115);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(111, 35);
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
            pictureBox1.Location = new Point(49, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(678, 210);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(metroControlBox4);
            panel1.Controls.Add(metroControlBox3);
            panel1.Controls.Add(metroControlBox2);
            panel1.Controls.Add(metroControlBox1);
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 43);
            panel1.TabIndex = 29;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // metroControlBox4
            // 
            metroControlBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox4.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox4.CloseHoverForeColor = Color.White;
            metroControlBox4.CloseNormalForeColor = Color.Gray;
            metroControlBox4.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox4.DisabledForeColor = Color.DimGray;
            metroControlBox4.IsDerivedStyle = true;
            metroControlBox4.Location = new Point(671, 10);
            metroControlBox4.MaximizeBox = true;
            metroControlBox4.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox4.MaximizeHoverForeColor = Color.Gray;
            metroControlBox4.MaximizeNormalForeColor = Color.Gray;
            metroControlBox4.MinimizeBox = true;
            metroControlBox4.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox4.MinimizeHoverForeColor = Color.Gray;
            metroControlBox4.MinimizeNormalForeColor = Color.Gray;
            metroControlBox4.Name = "metroControlBox4";
            metroControlBox4.Size = new Size(100, 25);
            metroControlBox4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox4.StyleManager = null;
            metroControlBox4.TabIndex = 30;
            metroControlBox4.Text = "metroControlBox4";
            metroControlBox4.ThemeAuthor = "Taiizor";
            metroControlBox4.ThemeName = "MetroLight";
            // 
            // metroControlBox3
            // 
            metroControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox3.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox3.CloseHoverForeColor = Color.White;
            metroControlBox3.CloseNormalForeColor = Color.Gray;
            metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox3.DisabledForeColor = Color.DimGray;
            metroControlBox3.IsDerivedStyle = true;
            metroControlBox3.Location = new Point(1239, 10);
            metroControlBox3.MaximizeBox = true;
            metroControlBox3.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MaximizeHoverForeColor = Color.Gray;
            metroControlBox3.MaximizeNormalForeColor = Color.Gray;
            metroControlBox3.MinimizeBox = true;
            metroControlBox3.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MinimizeHoverForeColor = Color.Gray;
            metroControlBox3.MinimizeNormalForeColor = Color.Gray;
            metroControlBox3.Name = "metroControlBox3";
            metroControlBox3.Size = new Size(100, 25);
            metroControlBox3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox3.StyleManager = null;
            metroControlBox3.TabIndex = 29;
            metroControlBox3.Text = "metroControlBox3";
            metroControlBox3.ThemeAuthor = "Taiizor";
            metroControlBox3.ThemeName = "MetroLight";
            // 
            // metroControlBox2
            // 
            metroControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox2.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox2.CloseHoverForeColor = Color.White;
            metroControlBox2.CloseNormalForeColor = Color.Gray;
            metroControlBox2.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox2.DisabledForeColor = Color.DimGray;
            metroControlBox2.IsDerivedStyle = true;
            metroControlBox2.Location = new Point(1762, 9);
            metroControlBox2.MaximizeBox = true;
            metroControlBox2.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox2.MaximizeHoverForeColor = Color.Gray;
            metroControlBox2.MaximizeNormalForeColor = Color.Gray;
            metroControlBox2.MinimizeBox = true;
            metroControlBox2.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox2.MinimizeHoverForeColor = Color.Gray;
            metroControlBox2.MinimizeNormalForeColor = Color.Gray;
            metroControlBox2.Name = "metroControlBox2";
            metroControlBox2.Size = new Size(100, 25);
            metroControlBox2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox2.StyleManager = null;
            metroControlBox2.TabIndex = 28;
            metroControlBox2.Text = "metroControlBox2";
            metroControlBox2.ThemeAuthor = "Taiizor";
            metroControlBox2.ThemeName = "MetroLight";
            // 
            // metroControlBox1
            // 
            metroControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox1.CloseHoverForeColor = Color.White;
            metroControlBox1.CloseNormalForeColor = Color.Gray;
            metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox1.DisabledForeColor = Color.DimGray;
            metroControlBox1.IsDerivedStyle = true;
            metroControlBox1.Location = new Point(2332, 3);
            metroControlBox1.MaximizeBox = true;
            metroControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroControlBox1.MinimizeBox = true;
            metroControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroControlBox1.Name = "metroControlBox1";
            metroControlBox1.Size = new Size(100, 25);
            metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox1.StyleManager = null;
            metroControlBox1.TabIndex = 27;
            metroControlBox1.Text = "metroControlBox1";
            metroControlBox1.ThemeAuthor = "Taiizor";
            metroControlBox1.ThemeName = "MetroLight";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(546, 173);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 30;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(787, 496);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(delete_btn);
            Controls.Add(del_id);
            Controls.Add(User_id);
            Controls.Add(user_type);
            Controls.Add(Librarian);
            Controls.Add(Student);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteUser";
            Text = "Delete User";
            Load += DeleteUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox4;
        private Button button1;
    }
}