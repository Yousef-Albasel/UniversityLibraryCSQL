namespace UniversityLibraryFormsCSQL
{
    partial class SelectBook
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
            dataGridView1 = new DataGridView();
            TableLabel = new Label();
            TableSelection = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            BookNameTextBox = new TextBox();
            BookName = new Label();
            ISBN = new Label();
            ISBNTextBox = new TextBox();
            AvailableCheckBox = new CheckBox();
            CategoryTextBox = new ComboBox();
            Category = new Label();
            label3 = new Label();
            LanguageTextBox = new TextBox();
            label4 = new Label();
            LastName = new Label();
            LastNameTextBox = new TextBox();
            FirstName = new Label();
            FirstNameTextBox = new TextBox();
            Publisher = new Label();
            label5 = new Label();
            PublicationYearTextBox = new TextBox();
            label6 = new Label();
            PublisherNameTextBox = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(414, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(358, 417);
            dataGridView1.TabIndex = 15;
            // 
            // TableLabel
            // 
            TableLabel.AutoSize = true;
            TableLabel.BackColor = Color.Transparent;
            TableLabel.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableLabel.ForeColor = SystemColors.ControlLightLight;
            TableLabel.Location = new Point(19, 63);
            TableLabel.Name = "TableLabel";
            TableLabel.Size = new Size(37, 16);
            TableLabel.TabIndex = 16;
            TableLabel.Text = "Table";
            // 
            // TableSelection
            // 
            TableSelection.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TableSelection.ForeColor = SystemColors.WindowFrame;
            TableSelection.FormattingEnabled = true;
            TableSelection.Items.AddRange(new object[] { "Book", "Author", "Publisher", "Multiple" });
            TableSelection.Location = new Point(62, 61);
            TableSelection.Name = "TableSelection";
            TableSelection.Size = new Size(121, 21);
            TableSelection.TabIndex = 17;
            TableSelection.Text = "Select Table";
            TableSelection.SelectedIndexChanged += TableSelection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 21);
            label1.TabIndex = 18;
            label1.Text = "Library Selection Menu";
            // 
            // button1
            // 
            button1.Location = new Point(25, 400);
            button1.Name = "button1";
            button1.Size = new Size(115, 32);
            button1.TabIndex = 19;
            button1.Text = "Clear Fields";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(19, 95);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 20;
            label2.Text = "Book";
            // 
            // BookNameTextBox
            // 
            BookNameTextBox.Enabled = false;
            BookNameTextBox.Location = new Point(25, 134);
            BookNameTextBox.Name = "BookNameTextBox";
            BookNameTextBox.Size = new Size(115, 23);
            BookNameTextBox.TabIndex = 21;
            // 
            // BookName
            // 
            BookName.AutoSize = true;
            BookName.BackColor = Color.Transparent;
            BookName.Font = new Font("Arial", 8F);
            BookName.ForeColor = Color.White;
            BookName.Location = new Point(25, 117);
            BookName.Name = "BookName";
            BookName.Size = new Size(61, 14);
            BookName.TabIndex = 22;
            BookName.Text = "Book Name";
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.BackColor = Color.Transparent;
            ISBN.Font = new Font("Arial", 8F);
            ISBN.ForeColor = Color.White;
            ISBN.Location = new Point(165, 117);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(30, 14);
            ISBN.TabIndex = 24;
            ISBN.Text = "ISBN";
            // 
            // ISBNTextBox
            // 
            ISBNTextBox.Enabled = false;
            ISBNTextBox.Location = new Point(165, 134);
            ISBNTextBox.Name = "ISBNTextBox";
            ISBNTextBox.Size = new Size(115, 23);
            ISBNTextBox.TabIndex = 23;
            // 
            // AvailableCheckBox
            // 
            AvailableCheckBox.AutoSize = true;
            AvailableCheckBox.BackColor = Color.Transparent;
            AvailableCheckBox.Enabled = false;
            AvailableCheckBox.ForeColor = Color.White;
            AvailableCheckBox.Location = new Point(298, 134);
            AvailableCheckBox.Name = "AvailableCheckBox";
            AvailableCheckBox.Size = new Size(102, 19);
            AvailableCheckBox.TabIndex = 25;
            AvailableCheckBox.Text = "Only Available";
            AvailableCheckBox.UseVisualStyleBackColor = false;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Enabled = false;
            CategoryTextBox.FormattingEnabled = true;
            CategoryTextBox.Location = new Point(25, 187);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(115, 23);
            CategoryTextBox.TabIndex = 26;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.BackColor = Color.Transparent;
            Category.Font = new Font("Arial", 8F);
            Category.ForeColor = Color.White;
            Category.Location = new Point(25, 170);
            Category.Name = "Category";
            Category.Size = new Size(51, 14);
            Category.TabIndex = 27;
            Category.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 8F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(165, 170);
            label3.Name = "label3";
            label3.Size = new Size(55, 14);
            label3.TabIndex = 29;
            label3.Text = "Language";
            // 
            // LanguageTextBox
            // 
            LanguageTextBox.Enabled = false;
            LanguageTextBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LanguageTextBox.ForeColor = SystemColors.WindowFrame;
            LanguageTextBox.Location = new Point(165, 187);
            LanguageTextBox.Name = "LanguageTextBox";
            LanguageTextBox.Size = new Size(115, 22);
            LanguageTextBox.TabIndex = 28;
            LanguageTextBox.Text = "English";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(19, 225);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 30;
            label4.Text = "Author";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.BackColor = Color.Transparent;
            LastName.Font = new Font("Arial", 8F);
            LastName.ForeColor = Color.White;
            LastName.Location = new Point(165, 248);
            LastName.Name = "LastName";
            LastName.Size = new Size(58, 14);
            LastName.TabIndex = 34;
            LastName.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Enabled = false;
            LastNameTextBox.Location = new Point(165, 265);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(115, 23);
            LastNameTextBox.TabIndex = 33;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.BackColor = Color.Transparent;
            FirstName.Font = new Font("Arial", 8F);
            FirstName.ForeColor = Color.White;
            FirstName.Location = new Point(25, 248);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(58, 14);
            FirstName.TabIndex = 32;
            FirstName.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Enabled = false;
            FirstNameTextBox.Location = new Point(25, 265);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(115, 23);
            FirstNameTextBox.TabIndex = 31;
            // 
            // Publisher
            // 
            Publisher.AutoSize = true;
            Publisher.BackColor = Color.Transparent;
            Publisher.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Publisher.ForeColor = SystemColors.ButtonShadow;
            Publisher.Location = new Point(19, 308);
            Publisher.Name = "Publisher";
            Publisher.Size = new Size(57, 16);
            Publisher.TabIndex = 35;
            Publisher.Text = "Publisher";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(165, 329);
            label5.Name = "label5";
            label5.Size = new Size(84, 14);
            label5.TabIndex = 39;
            label5.Text = "Publication Year";
            // 
            // PublicationYearTextBox
            // 
            PublicationYearTextBox.Enabled = false;
            PublicationYearTextBox.Location = new Point(165, 346);
            PublicationYearTextBox.Name = "PublicationYearTextBox";
            PublicationYearTextBox.Size = new Size(115, 23);
            PublicationYearTextBox.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 8F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(25, 329);
            label6.Name = "label6";
            label6.Size = new Size(81, 14);
            label6.TabIndex = 37;
            label6.Text = "Publisher Name";
            // 
            // PublisherNameTextBox
            // 
            PublisherNameTextBox.Enabled = false;
            PublisherNameTextBox.Location = new Point(25, 346);
            PublisherNameTextBox.Name = "PublisherNameTextBox";
            PublisherNameTextBox.Size = new Size(115, 23);
            PublisherNameTextBox.TabIndex = 36;
            // 
            // button2
            // 
            button2.Location = new Point(165, 400);
            button2.Name = "button2";
            button2.Size = new Size(115, 32);
            button2.TabIndex = 40;
            button2.Text = "Load Data";
            button2.UseVisualStyleBackColor = true;
            // 
            // SelectBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG;
            ClientSize = new Size(800, 481);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(PublicationYearTextBox);
            Controls.Add(label6);
            Controls.Add(PublisherNameTextBox);
            Controls.Add(Publisher);
            Controls.Add(LastName);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstName);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LanguageTextBox);
            Controls.Add(Category);
            Controls.Add(CategoryTextBox);
            Controls.Add(AvailableCheckBox);
            Controls.Add(ISBN);
            Controls.Add(ISBNTextBox);
            Controls.Add(BookName);
            Controls.Add(BookNameTextBox);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(TableSelection);
            Controls.Add(TableLabel);
            Controls.Add(dataGridView1);
            Name = "SelectBook";
            Text = "SelectBook";
            Load += SelectBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label TableLabel;
        private ComboBox TableSelection;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox BookNameTextBox;
        private Label BookName;
        private Label ISBN;
        private TextBox ISBNTextBox;
        private CheckBox AvailableCheckBox;
        private ComboBox CategoryTextBox;
        private Label Category;
        private Label label3;
        private TextBox LanguageTextBox;
        private Label label4;
        private Label LastName;
        private TextBox LastNameTextBox;
        private Label FirstName;
        private TextBox FirstNameTextBox;
        private Label Publisher;
        private Label label5;
        private TextBox PublicationYearTextBox;
        private Label label6;
        private TextBox PublisherNameTextBox;
        private Button button2;
    }
}