namespace UniversityLibraryFormsCSQL
{
    partial class BrowseBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseBooks));
            dataGridView1 = new DataGridView();
            BookName = new DataGridViewTextBoxColumn();
            Language = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            PublicationYear = new DataGridViewTextBoxColumn();
            Availability = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookName, Language, Category, ISBN, Author, PublicationYear, Availability });
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(12, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(734, 365);
            dataGridView1.TabIndex = 0;
            // 
            // BookName
            // 
            BookName.HeaderText = "Name";
            BookName.Name = "BookName";
            // 
            // Language
            // 
            Language.HeaderText = "Language";
            Language.Name = "Language";
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.Name = "ISBN";
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.Name = "Author";
            // 
            // PublicationYear
            // 
            PublicationYear.HeaderText = "Publication Year";
            PublicationYear.Name = "PublicationYear";
            // 
            // Availability
            // 
            Availability.HeaderText = "Availability";
            Availability.Name = "Availability";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(41, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 39);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BrowseBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 486);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BrowseBooks";
            Text = "Browse Books";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Language;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn PublicationYear;
        private DataGridViewTextBoxColumn Availability;
    }
}