namespace UniversityLibraryFormsCSQL
{
    partial class DeleteBook
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
            ISBN = new TextBox();
            label2 = new Label();
            del_btn = new Button();
            SuspendLayout();
            // 
            // ISBN
            // 
            ISBN.Location = new Point(131, 33);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(201, 23);
            ISBN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 36);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter Book ISBN:";
            // 
            // del_btn
            // 
            del_btn.Location = new Point(131, 62);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(75, 23);
            del_btn.TabIndex = 3;
            del_btn.Text = "Delete";
            del_btn.UseVisualStyleBackColor = true;
            del_btn.Click += del_btn_Click_1;
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(372, 129);
            Controls.Add(del_btn);
            Controls.Add(label2);
            Controls.Add(ISBN);
            Name = "DeleteBook";
            Text = "DeleteBook";
            Load += DeleteBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ISBN;
        private Label label2;
        private Button del_btn;
    }
}