using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymFrm
{
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("It will delete your data.Confirm?", "Delete data", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ALEENA-44; database=gym ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "  delete from NewCustomer where MID = " + textBox1.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            else
            {
                this.Activate();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = ALEENA-44; database=gym            ; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "  select * from NewCustomer";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void DeleteMember_Load(object sender, EventArgs e)
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