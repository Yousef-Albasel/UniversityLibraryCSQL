namespace UniversityLibraryFormsCSQL
{
    partial class UserDashboard
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(59, 255);
            button1.Name = "button1";
            button1.Size = new Size(199, 66);
            button1.TabIndex = 0;
            button1.Text = "Browse Books";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(264, 255);
            button2.Name = "button2";
            button2.Size = new Size(204, 66);
            button2.TabIndex = 1;
            button2.Text = "Select Books";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Location = new Point(474, 255);
            button3.Name = "button3";
            button3.Size = new Size(203, 66);
            button3.TabIndex = 2;
            button3.Text = "Update User Details";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._66982lms1;
            ClientSize = new Size(782, 500);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UserDashboard";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}