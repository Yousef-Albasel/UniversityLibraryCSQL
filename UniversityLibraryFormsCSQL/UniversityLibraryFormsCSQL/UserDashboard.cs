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
    public partial class UserDashboard : Form
    {
        int userID = UserContext.UserID;
        public Point mouseLocation;
        public UserDashboard()
        {
            InitializeComponent();
            LoadStudentDetails();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUserINFO update = new UpdateUserINFO();
            update.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrowseBooks browse = new BrowseBooks();
            browse.Show();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SelectBook SelectForm = new SelectBook();
            SelectForm.Show();
        }
        private void UserDashboard_Load(object sender, EventArgs e)
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

        private void Browse_Button_Click(object sender, EventArgs e)
        {
            BrowseBooks browse = new BrowseBooks();
            browse.Show();
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            SelectBook SelectForm = new SelectBook();
            SelectForm.Show();
            this.Close();
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            UpdateUserINFO update = new UpdateUserINFO();
            update.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadStudentDetails()
        {
            string connectionString = ConnectionStringHelper.ConnectionString;
            string query = $" SELECT * FROM STUDENT WHERE STUDENT_ID = {UserContext.UserID};";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
        }

    }
}
