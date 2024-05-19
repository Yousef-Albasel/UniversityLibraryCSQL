using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityLibraryFormsCSQL
{
    public partial class UpdateUserINFO : Form
    {
        public Point mouseLocation;
        public UpdateUserINFO()
        {
            InitializeComponent();
            textBox1.Text = UserContext.UserID.ToString();
            textBox1.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = ConnectionStringHelper.ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update STUDENT Set S_PASSWORD=@Password, S_EMAIL=@Email, MAJOR=@Major, S_FIRST_NAME=@FirstName, S_SECOND_NAME=@SecondName Where STUDENT_ID=@ID ", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@Major", textBox6.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox4.Text);
            cmd.Parameters.AddWithValue("@SecondName", textBox5.Text);
            cmd.ExecuteNonQuery();

            con.Close();

            DialogResult dialog = MessageBox.Show("Your Information has been Updated Successfully");

            if (dialog == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void UpdateUserINFO_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            UserDashboard ud = new UserDashboard();
            ud.Show();
            this.Close();
        }
    }
}
