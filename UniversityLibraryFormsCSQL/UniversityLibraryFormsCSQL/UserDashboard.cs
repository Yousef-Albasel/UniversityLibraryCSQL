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
    public partial class UserDashboard : Form
    {
        int userID = UserContext.UserID;
        public UserDashboard()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateUserINFO update = new UpdateUserINFO();
            update.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{userID}");
        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e)
        {
            SelectBook SelectForm = new SelectBook();
            SelectForm.Show();
=======
        private void UserDashboard_Load(object sender, EventArgs e)
        {

>>>>>>> 4c20a14d829d2d0cc200620b2f7e58b74e512eac
        }
    }
}
