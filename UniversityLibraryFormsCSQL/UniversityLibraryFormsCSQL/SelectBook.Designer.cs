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
            SelectBookLabel = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SelectBookLabel
            // 
            SelectBookLabel.AutoSize = true;
            SelectBookLabel.BackColor = Color.Transparent;
            SelectBookLabel.Font = new Font("Arial", 18.25F, FontStyle.Bold);
            SelectBookLabel.ForeColor = SystemColors.Control;
            SelectBookLabel.Location = new Point(21, 19);
            SelectBookLabel.Name = "SelectBookLabel";
            SelectBookLabel.Size = new Size(156, 30);
            SelectBookLabel.TabIndex = 13;
            SelectBookLabel.Text = "Select Book";
            SelectBookLabel.Click += firstNameLabel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(34, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(738, 365);
            dataGridView1.TabIndex = 15;
            // 
            // SelectBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(dataGridView1);
            Controls.Add(SelectBookLabel);
            Name = "SelectBook";
            Text = "SelectBook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectBookLabel;
        private DataGridView dataGridView1;
    }
}