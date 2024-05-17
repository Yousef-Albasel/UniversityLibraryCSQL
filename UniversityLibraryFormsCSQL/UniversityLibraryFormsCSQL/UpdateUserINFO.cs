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
        public UpdateUserINFO()
        {
            InitializeComponent();
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
    }
}
