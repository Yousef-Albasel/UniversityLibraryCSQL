namespace UniversityLibraryFormsCSQL
{
    partial class AddAuthor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnAddAuthor = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 23);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 69);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 23);
            txtLastName.TabIndex = 1;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(227, 115);
            btnAddAuthor.Margin = new Padding(4, 3, 4, 3);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(88, 27);
            btnAddAuthor.TabIndex = 2;
            btnAddAuthor.Text = "Add Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(23, 27);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(23, 73);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // AddAuthor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 163);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnAddAuthor);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddAuthor";
            Text = "Add Author";
            Load += AddAuthor_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
