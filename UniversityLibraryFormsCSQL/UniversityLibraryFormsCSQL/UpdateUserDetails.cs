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
    public partial class UpdateUserDetails : Form
    {
        public UpdateUserDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = ConnectionStringHelper.ConnectionString;
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand ("Update LIBRARIAN Set L_PASSWORD=@Password, L_EMAIL=@Email, DEPARTMENT=@Department, L_FIRST_NAME=@FirstName, L_LAST_NAME=@SecondName Where LIBRARIAN_ID=@ID ", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            cmd.Parameters.AddWithValue("@Department", textBox6.Text);
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

        private void UpdateUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
