using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GymFrm
{
    public partial class NewCustomerFrm : Form
    {
        public NewCustomerFrm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" Data Source=Aleena-44;Initial Catalog=gymManagemeent;Integrated Security=True;Encrypt=False");



        private void btnSave_Click(object sender, EventArgs e)

        {
            String fname = txtName.Text;

           

            String DOB = dateTimePickerDob.Text;

            String mobile = (txtMobile.Text);
            String Age = txtAge.Text;
            String Gender = cmbxGender.Text;

            String email = txtEmail.Text;

            String JoinDate = dateTimePickerJoinDate.Text;

            String gymTime = comboBoxGymTime.Text;

            String address = txtAddress.Text;

            String Membership = comboBoxMembership.Text;



            SqlConnection con = new SqlConnection(" Data Source=Aleena-44;Initial Catalog=gymManagemeent;Integrated Security=True;Encrypt=False");


            con.Open();
            SqlCommand command = new SqlCommand("insert into NewCustomer (Name,Age,Gender,Dob,Mobile,Email,JoinDate,GymTime,Maddress,MembershipTime)values ('" + fname + "','" + Age + "','" + Gender + "','" + DOB + "'," + mobile + "','" + JoinDate + "','" + gymTime + "','" + address + " ','" + Membership + "')");
            MessageBox.Show("Data inserted successfully");
            con.Close();

        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("Select * from NewCustomer", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void NewCustomerFrm_Load(object sender, EventArgs e)
        {
            BindData();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            cmbxGender.ResetText();




            txtMobile.Clear();
            txtEmail.Clear();

            comboBoxGymTime.ResetText();
            comboBoxMembership.ResetText();
            txtAddress.Clear();



            dateTimePickerDob.Value = DateTime.Now;
            dateTimePickerJoinDate.Value = DateTime.Now;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
    }

           

