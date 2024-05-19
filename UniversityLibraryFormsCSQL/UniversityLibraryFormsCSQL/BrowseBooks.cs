using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryFormsCSQL
{
    public partial class BrowseBooks : Form
    {
        public Point mouseLocation;
        public BrowseBooks()
        {
            InitializeComponent();
   
        }

        private void BrowseBooks_Load(object sender, EventArgs e)
        {
            string connectionString = ConnectionStringHelper.ConnectionString;
            string query = @"
                SELECT 
                    BOOKS.BOOK_NAME, 
                    BOOKS.ISBN, 
                    BOOKS.LANGUAGE,
                    BOOKS.AVAILABILITY,
                    AUTHOR.A_FIRST_NAME, 
                    AUTHOR.A_LAST_NAME,
                    PUBLISHER.PUBLISHER_NAME, 
                    BOOK_CATEGORY.CATEGORY
                FROM BOOKS
                JOIN AUTHOR ON BOOKS.AUTHOR_ID = AUTHOR.AUTHOR_ID
                JOIN PUBLISHER ON BOOKS.PUBLISHER_ID = PUBLISHER.PUBLISHER_ID
                JOIN BOOK_CATEGORY ON BOOKS.ISBN= BOOK_CATEGORY.ISPN";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

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
            UserDashboard ud = new UserDashboard();
            ud.Show();
            this.Close();
        }
    }
}
