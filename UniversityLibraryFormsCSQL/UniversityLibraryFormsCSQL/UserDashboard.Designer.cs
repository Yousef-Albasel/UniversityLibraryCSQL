namespace UniversityLibraryFormsCSQL
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            panel1 = new Panel();
            metroControlBox2 = new ReaLTaiizor.Controls.MetroControlBox();
            metroControlBox1 = new ReaLTaiizor.Controls.MetroControlBox();
            Browse_Button = new ReaLTaiizor.Controls.HopeButton();
            Select_Button = new ReaLTaiizor.Controls.HopeButton();
            Update_Button = new ReaLTaiizor.Controls.HopeButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(metroControlBox2);
            panel1.Controls.Add(metroControlBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 37);
            panel1.TabIndex = 27;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // metroControlBox2
            // 
            metroControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox2.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox2.CloseHoverForeColor = Color.White;
            metroControlBox2.CloseNormalForeColor = Color.Gray;
            metroControlBox2.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox2.DisabledForeColor = Color.DimGray;
            metroControlBox2.IsDerivedStyle = true;
            metroControlBox2.Location = new Point(620, 9);
            metroControlBox2.MaximizeBox = true;
            metroControlBox2.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox2.MaximizeHoverForeColor = Color.Gray;
            metroControlBox2.MaximizeNormalForeColor = Color.Gray;
            metroControlBox2.MinimizeBox = true;
            metroControlBox2.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox2.MinimizeHoverForeColor = Color.Gray;
            metroControlBox2.MinimizeNormalForeColor = Color.Gray;
            metroControlBox2.Name = "metroControlBox2";
            metroControlBox2.Size = new Size(100, 25);
            metroControlBox2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox2.StyleManager = null;
            metroControlBox2.TabIndex = 28;
            metroControlBox2.Text = "metroControlBox2";
            metroControlBox2.ThemeAuthor = "Taiizor";
            metroControlBox2.ThemeName = "MetroLight";
            // 
            // metroControlBox1
            // 
            metroControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox1.CloseHoverForeColor = Color.White;
            metroControlBox1.CloseNormalForeColor = Color.Gray;
            metroControlBox1.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox1.DisabledForeColor = Color.DimGray;
            metroControlBox1.IsDerivedStyle = true;
            metroControlBox1.Location = new Point(1190, 3);
            metroControlBox1.MaximizeBox = true;
            metroControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroControlBox1.MinimizeBox = true;
            metroControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroControlBox1.Name = "metroControlBox1";
            metroControlBox1.Size = new Size(100, 25);
            metroControlBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox1.StyleManager = null;
            metroControlBox1.TabIndex = 27;
            metroControlBox1.Text = "metroControlBox1";
            metroControlBox1.ThemeAuthor = "Taiizor";
            metroControlBox1.ThemeName = "MetroLight";
            // 
            // Browse_Button
            // 
            Browse_Button.BackColor = SystemColors.ActiveBorder;
            Browse_Button.BorderColor = Color.FromArgb(220, 223, 230);
            Browse_Button.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Browse_Button.DangerColor = Color.FromArgb(245, 108, 108);
            Browse_Button.DefaultColor = Color.FromArgb(255, 255, 255);
            Browse_Button.Font = new Font("Segoe UI", 12F);
            Browse_Button.HoverTextColor = Color.FromArgb(48, 49, 51);
            Browse_Button.InfoColor = Color.FromArgb(144, 147, 153);
            Browse_Button.Location = new Point(79, 174);
            Browse_Button.Name = "Browse_Button";
            Browse_Button.PrimaryColor = Color.BlueViolet;
            Browse_Button.Size = new Size(174, 44);
            Browse_Button.SuccessColor = Color.FromArgb(103, 194, 58);
            Browse_Button.TabIndex = 28;
            Browse_Button.Text = "Browse Books";
            Browse_Button.TextColor = Color.White;
            Browse_Button.WarningColor = Color.FromArgb(230, 162, 60);
            Browse_Button.Click += Browse_Button_Click;
            // 
            // Select_Button
            // 
            Select_Button.BackColor = SystemColors.ActiveBorder;
            Select_Button.BorderColor = Color.FromArgb(220, 223, 230);
            Select_Button.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Select_Button.DangerColor = Color.FromArgb(245, 108, 108);
            Select_Button.DefaultColor = Color.FromArgb(255, 255, 255);
            Select_Button.Font = new Font("Segoe UI", 12F);
            Select_Button.HoverTextColor = Color.FromArgb(48, 49, 51);
            Select_Button.InfoColor = Color.FromArgb(144, 147, 153);
            Select_Button.Location = new Point(272, 174);
            Select_Button.Name = "Select_Button";
            Select_Button.PrimaryColor = Color.BlueViolet;
            Select_Button.Size = new Size(174, 44);
            Select_Button.SuccessColor = Color.FromArgb(103, 194, 58);
            Select_Button.TabIndex = 29;
            Select_Button.Text = "Select Books";
            Select_Button.TextColor = Color.White;
            Select_Button.WarningColor = Color.FromArgb(230, 162, 60);
            Select_Button.Click += Select_Button_Click;
            // 
            // Update_Button
            // 
            Update_Button.BackColor = SystemColors.ActiveBorder;
            Update_Button.BorderColor = Color.FromArgb(220, 223, 230);
            Update_Button.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            Update_Button.DangerColor = Color.FromArgb(245, 108, 108);
            Update_Button.DefaultColor = Color.FromArgb(255, 255, 255);
            Update_Button.Font = new Font("Segoe UI", 12F);
            Update_Button.HoverTextColor = Color.FromArgb(48, 49, 51);
            Update_Button.InfoColor = Color.FromArgb(144, 147, 153);
            Update_Button.Location = new Point(471, 174);
            Update_Button.Name = "Update_Button";
            Update_Button.PrimaryColor = Color.BlueViolet;
            Update_Button.Size = new Size(174, 44);
            Update_Button.SuccessColor = Color.FromArgb(103, 194, 58);
            Update_Button.TabIndex = 30;
            Update_Button.Text = "Update User Details";
            Update_Button.TextColor = Color.White;
            Update_Button.WarningColor = Color.FromArgb(230, 162, 60);
            Update_Button.Click += Update_Button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(566, 110);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(731, 448);
            Controls.Add(dataGridView1);
            Controls.Add(Update_Button);
            Controls.Add(Select_Button);
            Controls.Add(Browse_Button);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserDashboard";
            Text = "UseDashboard";
            Load += UserDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private ReaLTaiizor.Controls.HopeButton Browse_Button;
        private ReaLTaiizor.Controls.HopeButton Select_Button;
        private ReaLTaiizor.Controls.HopeButton Update_Button;
        private DataGridView dataGridView1;
    }
}