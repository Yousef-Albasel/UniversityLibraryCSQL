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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtCategory
            this.txtCategory.Location = new System.Drawing.Point(120, 20);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(150, 20);
            this.txtCategory.TabIndex = 0;

            // txtISBN
            this.txtISBN.Location = new System.Drawing.Point(120, 60);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(150, 20);
            this.txtISBN.TabIndex = 1;

            // btnAddCategory
            this.btnAddCategory.Location = new System.Drawing.Point(195, 100);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 23);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 23);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";

            // lblISBN
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(20, 63);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN";

            // AddCategory
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtCategory);
            this.Name = "AddCategory";
            this.Text = "Add Category";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
