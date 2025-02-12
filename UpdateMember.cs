using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymFrm
{
    public partial class UpdateMember : Form
    {
        DataTable table = new DataTable("table");
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("It will update your data.Confirm?", "Update data", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ALEENA-44; database=gym; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "  update from NewCustomer where MID = " + txtUpdate.Text + "";
            }
        }
    




            private void UpdateMember_Load(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ALEENA-44; database=gym ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "  select * from NewCustomer  ";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                DeleteMember dm = new DeleteMember();

                dm.Show();

            }
        }
        }
      

