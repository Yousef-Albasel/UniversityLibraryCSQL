namespace UniversityLibraryFormsCSQL
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            secondNameTextBox = new TextBox();
            secondNameLabel = new Label();
            chooseRegesterationLabel = new Label();
            majorTextBox = new TextBox();
            label8 = new Label();
            departmentTextBox = new TextBox();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            Signup = new Button();
            panel1 = new Panel();
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(271, 243);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(255, 23);
            passwordTextBox.TabIndex = 11;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(271, 196);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(255, 23);
            emailTextBox.TabIndex = 10;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(271, 226);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(63, 14);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(271, 179);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 14);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            emailLabel.Click += emailLabel_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(271, 153);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(118, 23);
            firstNameTextBox.TabIndex = 13;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            firstNameLabel.ForeColor = Color.White;
            firstNameLabel.Location = new Point(271, 136);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(66, 14);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // secondNameTextBox
            // 
            secondNameTextBox.Location = new Point(407, 153);
            secondNameTextBox.Name = "secondNameTextBox";
            secondNameTextBox.Size = new Size(118, 23);
            secondNameTextBox.TabIndex = 15;
            secondNameTextBox.TextChanged += secondNameTextBox_TextChanged;
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.BackColor = Color.Transparent;
            secondNameLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            secondNameLabel.ForeColor = Color.White;
            secondNameLabel.Location = new Point(407, 136);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new Size(82, 14);
            secondNameLabel.TabIndex = 14;
            secondNameLabel.Text = "Second Name";
            secondNameLabel.Click += secondNameLabel_Click;
            // 
            // chooseRegesterationLabel
            // 
            chooseRegesterationLabel.AutoSize = true;
            chooseRegesterationLabel.BackColor = Color.Transparent;
            chooseRegesterationLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseRegesterationLabel.ForeColor = Color.White;
            chooseRegesterationLabel.Location = new Point(270, 276);
            chooseRegesterationLabel.Name = "chooseRegesterationLabel";
            chooseRegesterationLabel.Size = new Size(152, 14);
            chooseRegesterationLabel.TabIndex = 17;
            chooseRegesterationLabel.Text = "Choose registeration type";
            chooseRegesterationLabel.Click += chooseRegesterationLabel_Click;
            // 
            // majorTextBox
            // 
            majorTextBox.Location = new Point(270, 337);
            majorTextBox.Name = "majorTextBox";
            majorTextBox.Size = new Size(255, 23);
            majorTextBox.TabIndex = 20;
            majorTextBox.Visible = false;
            majorTextBox.TextChanged += majorTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(270, 320);
            label8.Name = "label8";
            label8.Size = new Size(38, 14);
            label8.TabIndex = 19;
            label8.Text = "Major";
            label8.Visible = false;
            label8.Click += label8_Click;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(270, 337);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(255, 23);
            departmentTextBox.TabIndex = 22;
            departmentTextBox.TextChanged += departmentTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(271, 320);
            label9.Name = "label9";
            label9.Size = new Size(72, 14);
            label9.TabIndex = 21;
            label9.Text = "Department";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(281, 292);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(121, 19);
            radioButton1.TabIndex = 23;
            radioButton1.Text = "register as student";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(411, 292);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 19);
            radioButton2.TabIndex = 24;
            radioButton2.Text = "register as admin";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Signup
            // 
            Signup.BackColor = Color.Indigo;
            Signup.FlatStyle = FlatStyle.Popup;
            Signup.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Signup.ForeColor = Color.White;
            Signup.Location = new Point(345, 376);
            Signup.Name = "Signup";
            Signup.Size = new Size(102, 33);
            Signup.TabIndex = 25;
            Signup.Text = "Sign up";
            Signup.UseVisualStyleBackColor = false;
            Signup.Click += Signup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(metroControlBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 37);
            panel1.TabIndex = 26;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
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
            metroControlBox1.Location = new Point(656, 3);
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 467);
            Controls.Add(panel1);
            Controls.Add(Signup);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(departmentTextBox);
            Controls.Add(label9);
            Controls.Add(majorTextBox);
            Controls.Add(label8);
            Controls.Add(chooseRegesterationLabel);
            Controls.Add(secondNameTextBox);
            Controls.Add(secondNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "University Library | Sign Up";
            Load += Form2_Load;
            MouseDown += Register_MouseDown;
            MouseMove += Register_MouseMove;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private Label emailLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox secondNameTextBox;
        private Label secondNameLabel;
        private Label chooseRegesterationLabel;
        private TextBox majorTextBox;
        private Label label8;
        private TextBox departmentTextBox;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button Signup;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
    }
}