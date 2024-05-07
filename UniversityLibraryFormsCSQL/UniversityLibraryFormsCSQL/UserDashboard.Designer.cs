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
            button2 = new Button();
            ff = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(218, 209);
            button2.Name = "button2";
            button2.Size = new Size(153, 52);
            button2.TabIndex = 1;
            button2.Text = "Browse Books";
            button2.UseVisualStyleBackColor = false;
            // 
            // ff
            // 
            ff.BackColor = SystemColors.ControlLightLight;
            ff.Location = new Point(37, 209);
            ff.Name = "ff";
            ff.Size = new Size(175, 52);
            ff.TabIndex = 2;
            ff.Text = "Select Books";
            ff.UseVisualStyleBackColor = false;
            ff.Click += ff_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Location = new Point(377, 209);
            button1.Name = "button1";
            button1.Size = new Size(202, 52);
            button1.TabIndex = 3;
            button1.Text = "Update User Details";
            button1.UseVisualStyleBackColor = false;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._66982lms;
            ClientSize = new Size(636, 396);
            Controls.Add(button1);
            Controls.Add(ff);
            Controls.Add(button2);
            Name = "UserDashboard";
            Text = "UserDashboard";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button ff;
        private Button button1;
    }
}