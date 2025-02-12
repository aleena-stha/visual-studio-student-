using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymFrm
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" Data Source=Aleena-44;Initial Catalog=gymManagemeent;Integrated Security=True;Encrypt=False");


        private void btnSearch_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                // Display error message in a dialogue box
                MessageBox.Show("Please fill in all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string s = " SELECT * from NewCustomer WHERE MID =" + ""
                + txtSearch.Text + "";
                dataGridView1.DataSource = DbConnection.GetTableByQuery(s);
                DbConnection.ExecuteNonQuery(s);
            }

        }
    }
}

       
    




