using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace UniversityLibraryFormsCSQL
{
    public partial class Register : Form
    {
        string connString = ConnectionStringHelper.ConnectionString;
        bool isStudent = false;
        bool isAdmin = false;
        ErrorProvider errorProvider = new ErrorProvider();
        public Register()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void secondNameLabel_Click(object sender, EventArgs e)
        {

        }
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            departmentTextBox.Visible = false;
            label9.Visible = false;
        }

        private void majorTextBox_TextChanged(object sender, EventArgs e) // major
        {

        }

        private void departmentTextBox_TextChanged(object sender, EventArgs e) // department
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isStudent = radioButton1.Checked;
            majorTextBox.Visible = isStudent;
            label8.Visible = isStudent;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isAdmin = radioButton2.Checked;
            departmentTextBox.Visible = isAdmin;
            label9.Visible = isAdmin;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


        }


        private void secondNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void chooseRegesterationLabel_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return; 
            }


            string firstName = firstNameTextBox.Text;
            string lastName = secondNameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string major = majorTextBox.Text;
            string department = departmentTextBox.Text;
            int studentID = GetNextStudentID();
            int librarianID = GetNextLibrarianID();
            if (isStudent)
            {
                InsertUser(studentID, 0, major, "", firstName, lastName, email, password);
                this.Close();    
            }
            else if (isAdmin)
            {
                InsertUser(0, librarianID, "", department, firstName, lastName, email, password); 
                this.Close();
            }
        }


        private int GetNextStudentID()
        {
            int nextID = 0;
            string query = "SELECT MAX(STUDENT_ID) FROM STUDENT;";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        nextID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        nextID = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the student ID: " + ex.Message);
                }
            }

            return nextID;
        }

        private int GetNextLibrarianID()
        {
            int nextID = 0;
            string query = "SELECT MAX(LIBRARIAN_ID) FROM LIBRARIAN;";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        nextID = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        nextID = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving the librarian ID: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return nextID;
        }
        private bool ValidateInputs()
        {
            // Validate first name
            string firstName = firstNameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(firstName) || firstName.Length < 2)
            {
                errorProvider.SetError(firstNameTextBox, "First name is required and must be at least 2 characters.");
                return false;
            }
            else if (!Regex.IsMatch(firstName, @"^[A-Za-z][A-Za-z0-9_]*[A-Za-z]$"))
            {
                errorProvider.SetError(firstNameTextBox, "First name can only contain letters and underscores, no whitespace or special characters.");
                return false;
            }
            else
            {
                errorProvider.SetError(firstNameTextBox, "");
            }

            // Validate last name
            string lastName = secondNameTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(lastName) || lastName.Length < 2)
            {
                errorProvider.SetError(secondNameTextBox, "Last name is required and must be at least 2 characters.");
                return false;
            }
            else if (!Regex.IsMatch(lastName, @"^[A-Za-z][A-Za-z0-9_]*[A-Za-z]$"))
            {
                errorProvider.SetError(secondNameTextBox, "Last name can only contain letters and underscores, no whitespace or special characters.");
                return false;
            }
            else
            {
                errorProvider.SetError(secondNameTextBox, "");
            }
            // Validate email
            string email = emailTextBox.Text;
            
            if (CheckIfEmailExists(email))
            {
                errorProvider.SetError(emailTextBox, "Email already in use!");
                return false; // Email already exists
            }
            else
            {
                errorProvider.SetError(emailTextBox, "");
            }

            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(emailTextBox.Text, emailPattern))
            {
                errorProvider.SetError(emailTextBox, "Invalid email format.");
                return false;
            }
            else
            {
                errorProvider.SetError(emailTextBox, "");
            }

            // Validate password
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                errorProvider.SetError(passwordTextBox, "Password is required.");
                return false;
            }
            else if (!Regex.IsMatch(passwordTextBox.Text, @"^(?=.*[A-Z]).{8,20}$"))
            {
                errorProvider.SetError(passwordTextBox, "Password must contain at least one uppercase letter and be between 8 and 20 characters.");
                return false;
            }
            else
            {
                errorProvider.SetError(passwordTextBox, "");
            }


            // Validate major
            if (isStudent && string.IsNullOrWhiteSpace(majorTextBox.Text))
            {
                errorProvider.SetError(majorTextBox, "Major is required.");
                return false;
            }
            else
            {
                errorProvider.SetError(majorTextBox, "");
            }

            // Validate department
            if (isAdmin && string.IsNullOrWhiteSpace(departmentTextBox.Text))
            {
                errorProvider.SetError(departmentTextBox, "Department is required.");
                return false;
            }
            else
            {
                errorProvider.SetError(departmentTextBox, "");
            }

            // All good 
            return true;
        }

        private bool CheckIfEmailExists(string email)
        {
            string query = isStudent ? "SELECT COUNT(*) FROM STUDENT WHERE S_EMAIL = @Email" : "SELECT COUNT(*) FROM LIBRARIAN WHERE L_EMAIL = @Email";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand checkEmailCommand = new SqlCommand(query, connection);
                    checkEmailCommand.Parameters.AddWithValue("@Email", email);
                    int emailExistsCount = Convert.ToInt32(checkEmailCommand.ExecuteScalar());
                    return emailExistsCount > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while checking if the email exists: " + ex.Message);
                    return false;
                }
            }
        }

        private bool InsertUser(int studentID, int librarianID, string major,string department, string firstName, string lastName, string email, string password)
        {
            string query; 
            if (isStudent)
            {
                query = $"INSERT INTO STUDENT (STUDENT_ID, MAJOR, S_FIRST_NAME, S_SECOND_NAME, S_EMAIL, S_PASSWORD) " +
                               $"VALUES ({studentID}, '{major}', '{firstName}', '{lastName}', '{email}', '{password}')";
            }
            else if (isAdmin)
            {
                query = $"INSERT INTO LIBRARIAN (LIBRARIAN_ID, DEPARTMENT, L_FIRST_NAME, L_LAST_NAME, L_EMAIL, L_PASSWORD) " +
                               $"VALUES ({librarianID}, '{department}', '{firstName}', '{lastName}', '{email}', '{password}')";
            }
            else return false;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration Succeeded!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Registration failed!");
                    }
                }
                catch (Exception ex)
                {
                        MessageBox.Show("An error occurred while inserting the student: " + ex.Message);
                    return false;
                }
            }
            return false;
        }


    }

}