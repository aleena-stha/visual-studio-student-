using System;
using System.Windows.Forms;

namespace GymFrm
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtGymId.Text == "Aleena" && txtPass.Text == "5678")
            {
                MdiFrm fm = new MdiFrm();
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect userId or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRst_Click(object sender, EventArgs e)
        {
            txtGymId.Clear();
            txtPass.Clear();
        }
    }
}
