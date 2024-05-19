using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryFormsCSQL
{
    public partial class UpdateBook : Form
    {
        public Point mouseLocation;
        public UpdateBook()
        {
            InitializeComponent();
        }
        string connString = ConnectionStringHelper.ConnectionString;


        private void button1_Click(object sender, EventArgs e)
        {
            bool? availability = null; // Use nullable bool

            if (checkBox1.Checked)
            {
                availability = true;
            }
            else if (!checkBox1.Checked)
            {
                availability = false;
            }

            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update BOOKS set BOOK_NAME = @BookName, AVAILABILITY=@Availability, LANGUAGE=@Language where ISBN=@ISBN", con);
            cmd.Parameters.AddWithValue("@ISBN", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@BookName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Availability", availability);
            cmd.Parameters.AddWithValue("@Language", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();

            DialogResult dialog = MessageBox.Show("Book Information has been Updated Successfully");

            if (dialog == DialogResult.OK)
            {
                AdminDashboard ad = new AdminDashboard();
                ad.Show();
                this.Close();
            }
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
