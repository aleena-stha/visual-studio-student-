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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymFrm
{
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
        }

       

        private void btnViewMember_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("It will show your data.Confirm?", "Showdata", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ("Data Source=Aleena-44;Initial Catalog=gymManagemeent;Integrated Security=True;Encrypt=False");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewCustomer " ;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            else
            {
                this.Activate();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ALEENA-44; database=gym ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "  select * from NewCustomer";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void MemberList_Load(object sender, EventArgs e)
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
    }
    }




