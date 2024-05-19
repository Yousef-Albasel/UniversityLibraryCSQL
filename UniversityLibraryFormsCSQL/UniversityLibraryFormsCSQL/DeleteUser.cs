using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UniversityLibraryFormsCSQL
{
    public partial class DeleteUser : Form
    {
        public Point mouseLocation;
        string connString = ConnectionStringHelper.ConnectionString;
        public DeleteUser()
        {
            InitializeComponent();
            showData();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();

                int id = Int32.Parse(del_id.Text);
                if (Student.Checked == true)
                {
                    var deleteCommand = new SqlCommand("DELETE FROM STUDENT WHERE STUDENT_ID = @ID", connection);
                    deleteCommand.Parameters.AddWithValue("@ID", id);
                    deleteCommand.ExecuteNonQuery();
                    showData();

                }
                else if (Librarian.Checked == true)
                {
                    var deleteCommand = new SqlCommand("DELETE FROM LIBRARIAN WHERE LIBRARIAN_ID = @ID", connection);
                    deleteCommand.Parameters.AddWithValue("@ID", id);
                    deleteCommand.ExecuteNonQuery();
                    showData();
                }

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void showData()
        {
            string userType = "STUDENT";
            if (Student.Checked)
            {
                userType = "STUDENT";
            }
            else if (Librarian.Checked)
            {
                userType = "LIBRARIAN";
            }
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();

                string query = $"SELECT * FROM {userType};";

                using (var command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Close();
        }
    }
}
