namespace UniversityLibraryFormsCSQL
{
    partial class AddBook
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
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnAddCategory;
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            radioButton2 = new RadioButton();
            pictureBox1 = new PictureBox();
            CategoryCombo = new ComboBox();
            AuthorCombo = new ComboBox();
            PublisherCombo = new ComboBox();
            btnAddAuthor = new Button();
            btnAddPublisher = new Button();
            btnAddCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(91, 90);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 22);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(93, 251);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 2;
            label3.Text = "Language";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(439, 90);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 22);
            label4.TabIndex = 3;
            label4.Text = "Category";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(439, 251);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 22);
            label5.TabIndex = 4;
            label5.Text = "Publisher";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(93, 172);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 22);
            label6.TabIndex = 4;
            label6.Text = "ISBN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(439, 172);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 22);
            label7.TabIndex = 5;
            label7.Text = "Author";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(91, 324);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 22);
            label8.TabIndex = 6;
            label8.Text = "Availability ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 32);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Arial", 12F);
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Location = new Point(93, 363);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 22);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Available";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 16F, FontStyle.Bold);
            button1.Location = new Point(93, 421);
            button1.Name = "button1";
            button1.Size = new Size(174, 38);
            button1.TabIndex = 15;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 32);
            textBox3.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(93, 197);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(197, 32);
            textBox5.TabIndex = 19;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Location = new Point(189, 363);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 22);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Not Available";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Add_Book;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(29, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 41);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // CategoryCombo
            // 
            CategoryCombo.FormattingEnabled = true;
            CategoryCombo.Location = new Point(439, 115);
            CategoryCombo.Name = "CategoryCombo";
            CategoryCombo.Size = new Size(197, 32);
            CategoryCombo.TabIndex = 23;
            CategoryCombo.SelectedIndexChanged += CategoryCombo_SelectedIndexChanged;
            // 
            // AuthorCombo
            // 
            AuthorCombo.FormattingEnabled = true;
            AuthorCombo.Location = new Point(439, 197);
            AuthorCombo.Name = "AuthorCombo";
            AuthorCombo.Size = new Size(197, 32);
            AuthorCombo.TabIndex = 24;
            AuthorCombo.SelectedIndexChanged += AuthorCombo_SelectedIndexChanged;
            // 
            // PublisherCombo
            // 
            PublisherCombo.FormattingEnabled = true;
            PublisherCombo.Location = new Point(439, 276);
            PublisherCombo.Name = "PublisherCombo";
            PublisherCombo.Size = new Size(197, 32);
            PublisherCombo.TabIndex = 25;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(439, 324);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(197, 36);
            btnAddAuthor.TabIndex = 0;
            btnAddAuthor.Text = "Add Author";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // btnAddPublisher
            // 
            btnAddPublisher.Location = new Point(439, 366);
            btnAddPublisher.Name = "btnAddPublisher";
            btnAddPublisher.Size = new Size(197, 32);
            btnAddPublisher.TabIndex = 1;
            btnAddPublisher.Text = "Add Publisher";
            btnAddPublisher.UseVisualStyleBackColor = true;
            btnAddPublisher.Click += btnAddPublisher_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(439, 404);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(197, 32);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            BackgroundImage = Properties.Resources.BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 496);
            Controls.Add(btnAddAuthor);
            Controls.Add(btnAddPublisher);
            Controls.Add(btnAddCategory);
            Controls.Add(PublisherCombo);
            Controls.Add(AuthorCombo);
            Controls.Add(CategoryCombo);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton2);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Arial", 16F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(20, 100);
            Margin = new Padding(7, 5, 7, 5);
            Name = "AddBook";
            Text = "AddBook";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private RadioButton radioButton2;
        private PictureBox pictureBox1;
        private ComboBox CategoryCombo;
        private ComboBox AuthorCombo;
        private ComboBox PublisherCombo;
    }
}