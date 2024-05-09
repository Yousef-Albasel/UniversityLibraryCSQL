
using System.Data.SqlClient;

namespace UniversityLibraryFormsCSQL
{
    public partial class Login : Form
    {
        string connString = ConnectionStringHelper.ConnectionString;
        bool? isStudent;
        int? userID = UserContext.UserID;
        public Login()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            CheckLoginCredentials(email, password);
            if (isStudent.HasValue && isStudent.Value)
            {
                UserDashboard userDashboard = new UserDashboard();
                userDashboard.Show();
            }
            else if (isStudent.HasValue && !isStudent.Value)
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form2 = new Register();

            form2.Show();

        }

        private bool CheckLoginCredentials(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    // Check student credentials
                    SqlCommand studentCommand = new SqlCommand("SELECT STUDENT_ID FROM STUDENT WHERE S_EMAIL = @Email AND S_PASSWORD = @Password", connection);
                    studentCommand.Parameters.AddWithValue("@Email", email);
                    studentCommand.Parameters.AddWithValue("@Password", password);
                    object studentResult = studentCommand.ExecuteScalar();
                    if (studentResult != null)
                    {
                        isStudent = true;
                        UserContext.UserID = Convert.ToInt32(studentResult);
                    }

                    // Check librarian credentials
                    SqlCommand librarianCommand = new SqlCommand("SELECT LIBRARIAN_ID FROM LIBRARIAN WHERE L_EMAIL = @Email AND L_PASSWORD = @Password", connection);
                    librarianCommand.Parameters.AddWithValue("@Email", email);
                    librarianCommand.Parameters.AddWithValue("@Password", password);
                    object librarianResult = librarianCommand.ExecuteScalar();
                    if (librarianResult != null)
                    {
                        isStudent = false;
                        UserContext.UserID = Convert.ToInt32(librarianResult);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking login credentials: " + ex.Message);
                }
            }
            return false;
        }
    }
}
