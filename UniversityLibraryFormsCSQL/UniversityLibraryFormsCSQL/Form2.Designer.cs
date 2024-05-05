namespace UniversityLibraryFormsCSQL
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            textBox4 = new TextBox();
            secondNameLabel = new Label();
            chooseRegesterationLabel = new Label();
            majorTextBox = new TextBox();
            label8 = new Label();
            departmentTextBox = new TextBox();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F);
            label2.Location = new Point(75, 30);
            label2.Name = "label2";
            label2.Size = new Size(168, 16);
            label2.TabIndex = 3;
            label2.Text = "Please create an account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 7);
            label1.Name = "label1";
            label1.Size = new Size(255, 23);
            label1.TabIndex = 2;
            label1.Text = "University Library Managment";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(32, 193);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(255, 23);
            passwordTextBox.TabIndex = 11;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(32, 146);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(255, 23);
            emailTextBox.TabIndex = 10;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = SystemColors.ActiveCaptionText;
            passwordLabel.Location = new Point(32, 176);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(63, 14);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            emailLabel.Location = new Point(32, 129);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 14);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            emailLabel.Click += emailLabel_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(32, 103);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(118, 23);
            firstNameTextBox.TabIndex = 13;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            firstNameLabel.Location = new Point(32, 86);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(66, 14);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 103);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 15;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // secondNameLabel
            // 
            secondNameLabel.AutoSize = true;
            secondNameLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            secondNameLabel.Location = new Point(168, 86);
            secondNameLabel.Name = "secondNameLabel";
            secondNameLabel.Size = new Size(82, 14);
            secondNameLabel.TabIndex = 14;
            secondNameLabel.Text = "Second Name";
            secondNameLabel.Click += secondNameLabel_Click;
            // 
            // chooseRegesterationLabel
            // 
            chooseRegesterationLabel.AutoSize = true;
            chooseRegesterationLabel.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chooseRegesterationLabel.ForeColor = SystemColors.ActiveCaptionText;
            chooseRegesterationLabel.Location = new Point(31, 226);
            chooseRegesterationLabel.Name = "chooseRegesterationLabel";
            chooseRegesterationLabel.Size = new Size(152, 14);
            chooseRegesterationLabel.TabIndex = 17;
            chooseRegesterationLabel.Text = "Choose registeration type";
            chooseRegesterationLabel.Click += chooseRegesterationLabel_Click;
            // 
            // majorTextBox
            // 
            majorTextBox.Location = new Point(32, 287);
            majorTextBox.Name = "majorTextBox";
            majorTextBox.Size = new Size(255, 23);
            majorTextBox.TabIndex = 20;
            majorTextBox.TextChanged += majorTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label8.Location = new Point(32, 270);
            label8.Name = "label8";
            label8.Size = new Size(38, 14);
            label8.TabIndex = 19;
            label8.Text = "Major";
            label8.Click += label8_Click;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(31, 287);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(255, 23);
            departmentTextBox.TabIndex = 22;
            departmentTextBox.TextChanged += departmentTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            label9.Location = new Point(31, 270);
            label9.Name = "label9";
            label9.Size = new Size(72, 14);
            label9.TabIndex = 21;
            label9.Text = "Department";
            label9.Click += label9_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(42, 242);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(121, 19);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "register as student";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(172, 242);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 19);
            radioButton2.TabIndex = 24;
            radioButton2.Text = "register as admin";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(106, 326);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 25;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 392);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(departmentTextBox);
            Controls.Add(label9);
            Controls.Add(majorTextBox);
            Controls.Add(label8);
            Controls.Add(chooseRegesterationLabel);
            Controls.Add(textBox4);
            Controls.Add(secondNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "University Library | Sign Up";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private Label emailLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox textBox4;
        private Label secondNameLabel;
        private Label chooseRegesterationLabel;
        private TextBox majorTextBox;
        private Label label8;
        private TextBox departmentTextBox;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
    }
}