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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(120, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 0;

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(120, 60);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 1;

            // btnAddAuthor
            this.btnAddAuthor.Location = new System.Drawing.Point(195, 100);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 2;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 23);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";

            // AddAuthor
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "AddAuthor";
            this.Text = "Add Author";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
