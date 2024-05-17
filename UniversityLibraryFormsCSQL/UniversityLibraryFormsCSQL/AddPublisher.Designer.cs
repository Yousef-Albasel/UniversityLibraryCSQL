namespace UniversityLibraryFormsCSQL
{
    partial class AddPublisher
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtPublisherId;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.Label lblPublisherId;

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
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.txtPublisherId = new System.Windows.Forms.TextBox();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.lblPublisherId = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtPublisherName
            this.txtPublisherName.Location = new System.Drawing.Point(120, 20);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(150, 20);
            this.txtPublisherName.TabIndex = 0;

            // txtPublisherId
            this.txtPublisherId.Location = new System.Drawing.Point(120, 60);
            this.txtPublisherId.Name = "txtPublisherId";
            this.txtPublisherId.Size = new System.Drawing.Size(150, 20);
            this.txtPublisherId.TabIndex = 1;

            // btnAddPublisher
            this.btnAddPublisher.Location = new System.Drawing.Point(195, 100);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(75, 23);
            this.btnAddPublisher.TabIndex = 2;
            this.btnAddPublisher.Text = "Add Publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);

            // lblPublisherName
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Location = new System.Drawing.Point(20, 23);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(79, 13);
            this.lblPublisherName.TabIndex = 3;
            this.lblPublisherName.Text = "Publisher Name";

            // lblPublisherId
            this.lblPublisherId.AutoSize = true;
            this.lblPublisherId.Location = new System.Drawing.Point(20, 63);
            this.lblPublisherId.Name = "lblPublisherId";
            this.lblPublisherId.Size = new System.Drawing.Size(67, 13);
            this.lblPublisherId.TabIndex = 4;
            this.lblPublisherId.Text = "Publisher ID";

            // AddPublisher
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblPublisherId);
            this.Controls.Add(this.lblPublisherName);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.txtPublisherId);
            this.Controls.Add(this.txtPublisherName);
            this.Name = "AddPublisher";
            this.Text = "Add Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
