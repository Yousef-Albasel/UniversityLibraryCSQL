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
        public UpdateBook()
        {
            InitializeComponent();
        }
        string connString = ConnectionStringHelper.ConnectionString;


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update BOOKS set BOOK_NAME = @BookName, AVAILABILITY=@Availability, LANGUAGE=@Language where ISBN=@ISBN", con);
            cmd.Parameters.AddWithValue("@ISBN", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@BookName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Availability", textBox3.Text);
            cmd.Parameters.AddWithValue("@Language", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();

            DialogResult dialog = MessageBox.Show("Book Information has been Updated Successfully");

            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {

        }
    }
}
