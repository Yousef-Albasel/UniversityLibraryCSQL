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
            txtPublisherName = new TextBox();
            txtPublisherId = new TextBox();
            btnAddPublisher = new Button();
            lblPublisherName = new Label();
            lblPublisherId = new Label();
            SuspendLayout();
            // 
            // txtPublisherName
            // 
            txtPublisherName.Location = new Point(140, 23);
            txtPublisherName.Margin = new Padding(4, 3, 4, 3);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(174, 23);
            txtPublisherName.TabIndex = 0;
            // 
            // txtPublisherId
            // 
            txtPublisherId.Location = new Point(140, 69);
            txtPublisherId.Margin = new Padding(4, 3, 4, 3);
            txtPublisherId.Name = "txtPublisherId";
            txtPublisherId.Size = new Size(174, 23);
            txtPublisherId.TabIndex = 1;
            // 
            // btnAddPublisher
            // 
            btnAddPublisher.Location = new Point(227, 115);
            btnAddPublisher.Margin = new Padding(4, 3, 4, 3);
            btnAddPublisher.Name = "btnAddPublisher";
            btnAddPublisher.Size = new Size(88, 27);
            btnAddPublisher.TabIndex = 2;
            btnAddPublisher.Text = "Add Publisher";
            btnAddPublisher.UseVisualStyleBackColor = true;
            btnAddPublisher.Click += btnAddPublisher_Click;
            // 
            // lblPublisherName
            // 
            lblPublisherName.AutoSize = true;
            lblPublisherName.Location = new Point(23, 27);
            lblPublisherName.Margin = new Padding(4, 0, 4, 0);
            lblPublisherName.Name = "lblPublisherName";
            lblPublisherName.Size = new Size(91, 15);
            lblPublisherName.TabIndex = 3;
            lblPublisherName.Text = "Publisher Name";
            // 
            // lblPublisherId
            // 
            lblPublisherId.AutoSize = true;
            lblPublisherId.Location = new Point(23, 73);
            lblPublisherId.Margin = new Padding(4, 0, 4, 0);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(70, 15);
            lblPublisherId.TabIndex = 4;
            lblPublisherId.Text = "Publisher ID";
            // 
            // AddPublisher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 163);
            Controls.Add(lblPublisherId);
            Controls.Add(lblPublisherName);
            Controls.Add(btnAddPublisher);
            Controls.Add(txtPublisherId);
            Controls.Add(txtPublisherName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddPublisher";
            Text = "Add Publisher";
            Load += AddPublisher_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
