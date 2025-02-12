using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymFrm
{
    public partial class MdiFrm : Form
    {
        public MdiFrm()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
            }

            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
            }


        }



        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomerFrm nm = new NewCustomerFrm();

            nm.Show();

        }

        private void updateAndDeleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateMember um = new UpdateMember();

            um.Show();
            /*UpdateDeletecs ud = new UpdateDeletecs();
             ud.Show();*/

        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sm = new SearchMember();

            sm.Show();
        }

        private void viewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberList ml = new MemberList();
            ml.Show();

        }

        private void billGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillCalculationFrm mn = new BillCalculationFrm();

            mn.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close  Your application . Confirm?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}