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
            label1 = new Label();
            ISBN = new TextBox();
            del_btn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(59, 176);
            label1.Name = "label1";
            label1.Size = new Size(65, 27);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // ISBN
            // 
            ISBN.Location = new Point(189, 176);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(201, 23);
            ISBN.TabIndex = 1;
            // 
            // del_btn
            // 
            del_btn.BackColor = SystemColors.Highlight;
            del_btn.FlatStyle = FlatStyle.Flat;
            del_btn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            del_btn.ForeColor = SystemColors.Control;
            del_btn.Location = new Point(59, 262);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(156, 41);
            del_btn.TabIndex = 2;
            del_btn.Text = "Delete";
            del_btn.UseMnemonic = false;
            del_btn.UseVisualStyleBackColor = false;
            del_btn.Click += del_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Delete_Book;
            pictureBox1.Location = new Point(42, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(790, 512);
            Controls.Add(pictureBox1);
            Controls.Add(del_btn);
            Controls.Add(ISBN);
            Controls.Add(label1);
            Name = "DeleteBook";
            Text = "DeleteBook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ISBN;
        private Button del_btn;
        private PictureBox pictureBox1;
    }
}