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

namespace UniversityLibraryFormsCSQL
{
    public partial class DeleteBook : Form
    {
        string connString = ConnectionStringHelper.ConnectionString;

        public DeleteBook()
        {
            InitializeComponent();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();

                int ISBN_ = Int32.Parse(ISBN.Text);

                var deleteCommand = new SqlCommand("DELETE FROM BOOKS WHERE ISBN = @ID", connection);
                deleteCommand.Parameters.AddWithValue("@ID", ISBN_);
                deleteCommand.ExecuteNonQuery();



            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
