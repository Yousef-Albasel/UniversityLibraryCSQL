using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryFormsCSQL
{
    public partial class Form2 : Form
    {
        bool isStudent = false;
        bool isAdmin = false;
        public Form2()
        {
            InitializeComponent();
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
        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void secondNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (isStudent)
            {

                UserDashboard form3 = new UserDashboard();
                form3.Show();
            }

        }
    }
}
