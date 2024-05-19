namespace UniversityLibraryFormsCSQL
{
    partial class AddCategory
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblISBN;

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
            txtCategory = new TextBox();
            txtISBN = new TextBox();
            btnAddCategory = new Button();
            lblCategory = new Label();
            lblISBN = new Label();
            SuspendLayout();
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(140, 23);
            txtCategory.Margin = new Padding(4, 3, 4, 3);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(174, 23);
            txtCategory.TabIndex = 0;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(140, 69);
            txtISBN.Margin = new Padding(4, 3, 4, 3);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(174, 23);
            txtISBN.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(227, 115);
            btnAddCategory.Margin = new Padding(4, 3, 4, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(88, 27);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 27);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(23, 73);
            lblISBN.Margin = new Padding(4, 0, 4, 0);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN";
            // 
            // AddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 163);
            Controls.Add(lblISBN);
            Controls.Add(lblCategory);
            Controls.Add(btnAddCategory);
            Controls.Add(txtISBN);
            Controls.Add(txtCategory);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddCategory";
            Text = "Add Category";
            Load += AddCategory_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
