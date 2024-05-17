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
        string connString = ConnectionStringHelper.ConnectionString;
        public DeleteUser()
        {
            InitializeComponent();
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

                }
                else if (Librarian.Checked == true)
                {
                    var deleteCommand = new SqlCommand("DELETE FROM LIBRARIAN WHERE LIBRARIAN_ID = @ID", connection);
                    deleteCommand.Parameters.AddWithValue("@ID", id);
                    deleteCommand.ExecuteNonQuery();
                }

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
