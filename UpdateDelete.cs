using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymFrm
{
    public partial class UpdateDelete : Form
    {

        // Function Con;
        
        public UpdateDelete()
        {
            InitializeComponent();
            //Con = new Function();
           // ShowUpdateDelete();
            
            


        }

        /*private bool IsEditMode;
        private void EnableDisableControl(String mode)
        {
            switch (mode)
            {
                case "Reset":
                    btnReset.Enabled = true;
                    btnDelete.Enabled = false;
                    
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    
                    comboBoxGender.Enabled = true;
                    txtMid.Enabled = false;

                    txtMid.Clear();
                    txtName.Clear();
                    txtAddress.Clear();
                    txtContact.Clear();
                    
                    txtMid.ReadOnly = true;
                    txtName.ReadOnly = true;




                    break;
                case "New":
                    
                    btnDelete.Enabled = false;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = false;
                    txtMonth.Enabled = true;
                    


                    txtMid.ReadOnly = true;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                 
                    dateTimePickerJoinDate.ReadOnly = false;

                    txtYear.ReadOnly = false;





                    break;
                case "Edit":
                   
                    btnDelete.Enabled = true;
                    ;
                    btnUpdate.Enabled = true;
                    txtMonth.Enabled = true;
                    txtGender.Enabled = true;

                    txtMid.ReadOnly = true;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtContactNo.ReadOnly = false;
                    txtDay.ReadOnly = false;
                    txtYear.ReadOnly = false;

                    break;
                case "Register":
                    btnInsert.Enabled = false;

                    break;
                case "Delete":
                    btnDelete.Enabled = false;





                    break;
            }
        */

        // SqlConnection con = new SqlConnection("  Data Source = Aleena - 44; Initial Catalog = gymManagemeent; Integrated Security = True; Encrypt = False");
        private void btnInsert_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;


            String Id = txtMid.Text;

            String Age = txtAge.Text;
            String Gender = comboBoxGender.Text;

            String mobile = (txtMobile.Text);

            String email = txtEmail.Text;

            String JoinDate = dateTimePickerJoinDate.Text;

            String gymTime = comboBoxGymTime.Text;

            String address = txtAddress.Text;

            String Membership = comboBoxMembership.Text;



            // EnableDisableControl("Insert");
            // inserts data in sql server database
            if (string.IsNullOrEmpty(txtMid.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtAge.Text)

                || string.IsNullOrEmpty(comboBoxGender.Text)
                || string.IsNullOrEmpty(txtMobile.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(dateTimePickerJoinDate.Text) ||
                string.IsNullOrEmpty(comboBoxGymTime.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(comboBoxMembership.Text))
            {
                // Display error message in a dialogue box
                MessageBox.Show("Please fill in all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else


            {
                String sqlstr = "insert into Insert(Customer_Id," + "Name,Age,Gender, Mobile, Email,JoinDate , GymTime, Address, Membership ) values("
                + txtMid.Text + ", '" + txtName.Text +
                "' , '" + txtAge.Text + "' ," + comboBoxGender.Text + ", '" + txtMobile.Text + "' ," +
                txtEmail.Text + ", '" + dateTimePickerJoinDate.Text + "' ,'" + comboBoxGymTime + "','" + txtAddress.Text + "','" +
                comboBoxMembership.Text + ")";


                DbConnection.ExecuteNonQuery(sqlstr);


                DialogResult suc;
                suc = MessageBox.Show("Sucessfully Registered");


            }
        }
            int key = 0;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            try

            {
                if (txtName.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || comboBoxGender.SelectedIndex == -1 || comboBoxGymTime.SelectedIndex == -1 || comboBoxMembership.SelectedIndex == -1 || dateTimePickerJoinDate.Text == "")

                {

                    MessageBox.Show("Missing Data!!!");

                }

                else

                {
                    string Name = txtName.Text;
                    int Age = Convert.ToInt32(txtAge.Text);
                    string Email = txtEmail.Text;
                    string Address = txtAddress.Text;
                    string Mobile = txtMobile.Text;
                    string Gender = comboBoxGender.SelectedItem.ToString();
                    string Gym_time = comboBoxGymTime.SelectedItem.ToString();
                    string Membership_time = comboBoxMembership.SelectedItem.ToString();
                    string Join_date = dateTimePickerJoinDate.Value.Date.ToString();

                    string Query = "update  Customer set  Name = '{0}', Age = {1}, Email = '{2}', Address = '{3}', Gender = '{4}',Gym_time = '{5}', Membership_time = '{6}', Join_date = '{7}'where MID = '{9}'";
                    Query = string.Format(Query, Name, Age, Email, Address, Mobile, Gender, Gym_time, Membership_time, Join_date, key);
                    
                    MessageBox.Show("Updated Successfully!!!");

                }

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
               
                txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                txtAge.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                comboBoxGender.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
                txtMobile.Text = dataGridView1.CurrentRow.Cells["Mobile"].Value.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
                dateTimePickerJoinDate.Text = dataGridView1.CurrentRow.Cells["Trainingplan"].Value.ToString();
                comboBoxGymTime.Text = dataGridView1.CurrentRow.Cells["Currentweight"].Value.ToString();
                comboBoxMembership.Text = dataGridView1.CurrentRow.Cells["Targetweight"].Value.ToString();
            }
    }
}
}
        

   /* private void DisplayData()
            {
                string sqlselect = "select * from gym";
                var data = DbConnection.GetTableByQuery(sqlselect);
                dataGridView1.DataSource = data;
            }
          
           
        
    private void UpdateDeletecs_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
            txtMobile.Text = dataGridView1.CurrentRow.Cells["Mobile"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            dateTimePickerJoinDate.Text = dataGridView1.CurrentRow.Cells["Trainingplan"].Value.ToString();
            comboBoxGymTime.Text = dataGridView1.CurrentRow.Cells["Currentweight"].Value.ToString();
            comboBoxMembership.Text = dataGridView1.CurrentRow.Cells["Targetweight"].Value.ToString();

        }
    }
}



try

{
    if (txtName.Text == "" || txtAge.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || cmbGender.SelectedIndex == -1 || cmbWorkout_time.SelectedIndex == -1 || cmbMembership_type.SelectedIndex == -1 || dtpRegistration_date.Text == "")

    {

        MessageBox.Show("Missing Data!!!");

    }

    else

    {
        string Name = txtName.Text;
        int Age = Convert.ToInt32(txtAge.Text);
        string Email = txtEmail.Text;
        string Address = txtAddress.Text;
        string Gender = cmbGender.SelectedItem.ToString();
        string Workout_time = cmbWorkout_time.SelectedItem.ToString();
        string Membership_type = cmbMembership_type.SelectedItem.ToString();
        string Registration_date = dtpRegistration_date.Value.Date.ToString();
        string Join_date = dtpJoin_date.Value.Date.ToString();
        string Query = "update  Dynamo set  Name = '{0}', Age = {1}, Email = '{2}', Address = '{3}', Gender = '{4}', Workout_time = '{5}', Membership_type = '{6}', Registration_date = '{7}', Join_date = '{8}'where Client_ID = '{9}'";
        Query = string.Format(Query, Name, Age, Email, Address, Gender, Workout_time, Membership_type, Registration_date, Join_date, key);
        Con.setData(Query);

        MessageBox.Show("Updated Successfully!!!");

    }

}

catch (Exception ex)

{
    MessageBox.Show(ex.Message);

}
        }

has context menu

       /* string sqlupdate = "update gym set Name='" + txtName.Text + "',gender='" + cmbGender.Text + "',mobile='" + txtMobile.Text + "',Address='" + txtAddress.Text + "',Trainingplan='" + cmbTrainingplan.Text + "',Currentweight='" + txtCurrentweight.Text + "',Targetweight='" + txtTargetweight.Text + "',Joindate='" + JoinDate.Text + "',Extraservices ='" + cmbExtraservices.Text + "' where ID= " + txtID.Text;
        DbConnection.ExecuteNonQuery(sqlupdate);

            MessageBox.Show("Data Upadate sucessfully");
            DisplayData();

        private void Update_Load(object sender, EventArgs e)
            {
                DisplayData();
            }
            private void DisplayData()
            {
                string sqlselect = "select * from gym";
                var data = Dbconnection.GetTableByQuery(sqlselect);
                dataGridView1.DataSource = data;
            }
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                string sqlupdate = "update gym set Name='" + txtName.Text + "',gender='" + cmbGender.Text + "',mobile='" + txtMobile.Text + "',Address='" + txtAddress.Text + "',Trainingplan='" + cmbTrainingplan.Text + "',Currentweight='" + txtCurrentweight.Text + "',Targetweight='" + txtTargetweight.Text + "',Joindate='" + JoinDate.Text + "',Extraservices ='" + cmbExtraservices.Text + "' where ID= " + txtID.Text;
                Dbconnection.ExecuteNonQuery(sqlupdate);

                MessageBox.Show("Data Upadate sucessfully");
                DisplayData();
            }

            private void dataGridView1_DoubleClick(object sender, EventArgs e)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                
                txtMobile.Text = dataGridView1.CurrentRow.Cells["Mobile"].Value.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
                cmbTrainingplan.Text = dataGridView1.CurrentRow.Cells["Trainingplan"].Value.ToString();
                                dateTimePickerJoinDate.Text = dataGridView1.CurrentRow.Cells["Joindate"].Value.ToString();
                
            }
     
    }

   
            
            private void btnSave_Click(object sender, EventArgs e)
            {
                string sqlstr = "insert into gym(ID,"
                    + "Name,Gender,Mobile,Address,Trainingplan,Currentweight,Targetweight,Joindate,Sauna,Swimming,Privatetrainer) " +
                    "values(" + txtID.Text + ",'" + txtName.Text + "'," + "'" + cmbGender.Text + "'" +
                    "," + txtMobile.Text + ",'"
                    + txtAddress.Text + "','" + cmbTrainingplan.Text + "','" + txtCurrentweight.Text + "','" + txtTargetweight.Text + "','" + JoinDate.Text + "','" + cmbExtraservices.Text + "','" + cmbSwimming.Text + "','" + cmbPrivatetraining.Text + "')";


                Dbconnection.ExecuteNonQuery(sqlstr);
                DialogResult suc;
                suc = MessageBox.Show("sucessfully saved");
            }
            private int GetID()
            {
                try
                {
                    string ID = "select max(ID+1)from gym";
                    var data = DbConnection.GetTableByQuery(ID);
                    return Convert.ToInt32(data.Rows[0][0]);
                }
                catch (Exception)
                {
                    return 0;
                }
            }

            private void btnNew_Click(object sender, EventArgs e)
            {
                {
                    txtID.Text = GetID().ToString();
                }

            }

            private void btnReset_Click(object sender, EventArgs e)
            {
                txtSearchID.Clear();
                txtFirstName.Clear();
              txtLastName.ResetText();
                txtMobile.ResetText();
                txtAddress.Clear();
            txtEmail.Clear();
            comboBoxMembership.ResetText();
            dateTimePickerJoinDate.ResetText();
               dateTimePickerDob.ResetText();
                txtG.ResetText();
                cmbSwimming.ResetText();
                cmbPrivatetraining.ResetText();
            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Delete");

            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtAddress.Text)
                || string.IsNullOrEmpty(txtLastName.Text)

              || string.IsNullOrEmpty(txtMobile.Text)
              || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(comboboxMembership.Text) || string.IsNullOrEmpty(txtMonth.Text) ||
              string.IsNullOrEmpty(txtYear.Text))
            {
                // Display error message in a dialogue box
                MessageBox.Show("Please fill in all the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

            { // This code deletes the data in database
                string del = " Delete from Registration WHERE Customer_Id =" + ""
                 + txtId.Text + "";
                DBConnection.ExecuteNonQuery(del);
                DialogResult de;
                de = MessageBox.Show("Deleted");
            }
        }
    }




    private void Update_Load(object sender, EventArgs e)
            {
                DisplayData();
            }
            private void DisplayData()
            {
                string sqlselect = "select * from gym";
                var data = DbConnection.GetTableByQuery(sqlselect);
                dataGridView1.DataSource = data;
            }
            private void btnUpdate_Click(object sender, EventArgs e)
            {
                string sqlupdate = "update gym set Name='" + txtFirstName.Text + "',gender='" + cmbGender.Text + "',mobile='" + txtMobile.Text + "',Address='" + txtAddress.Text + "',Trainingplan='" + cmbTrainingplan.Text + "',Currentweight='" + txtCurrentweight.Text + "',Targetweight='" + txtTargetweight.Text + "',Joindate='" + JoinDate.Text + "',Sauna ='" + cmbExtraservices.Text + "',Swimming ='" + cmbSwimming.Text + "',Privatetrainer='" + cmbPrivatetraining.Text + "' where ID= " + txtID.Text;
                Dbconnection.ExecuteNonQuery(sqlupdate);

                MessageBox.Show("Data Upadate sucessfully");
                DisplayData();
            }

            private void dataGridView1_DoubleClick(object sender, EventArgs e)
            {
                txtId.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                txtMobile.Text = dataGridView1.CurrentRow.Cells["Mobile"].Value.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
                cmbTrainingplan.Text = dataGridView1.CurrentRow.Cells["Trainingplan"].Value.ToString();
                txtCurrentweight.Text = dataGridView1.CurrentRow.Cells["Currentweight"].Value.ToString();
                txtTargetweight.Text = dataGridView1.CurrentRow.Cells["Targetweight"].Value.ToString();
                JoinDate.Text = dataGridView1.CurrentRow.Cells["Joindate"].Value.ToString();
                cmbExtraservices.Text = dataGridView1.CurrentRow.Cells["Sauna"].Value.ToString();
                cmbSwimming.Text = dataGridView1.CurrentRow.Cells["Swimming"].Value.ToString();
                cmbPrivatetraining.Text = dataGridView1.CurrentRow.Cells["Privatetrainer"].Value.ToString();

            }
        }
    }

   

}
           

           
        
    }
    private void DisplayData()
        {
            string sqlselect = "select * from gym";
            var data = DbConnection.GetTableByQuery(sqlselect);
            dataGridView1.DataSource = data;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure to delete the data", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.No)
                return;

            string sqldelete = "Delete from gym where id=" + MID.Text;
            DbConnection.ExecuteNonQuery(sqldelete);
            MessageBox.Show("data delete sucessfully");
            DisplayData();
        }
    private void UpdateDeletecs_Load(object sender, EventArgs e)
    {
        DisplayData();
    }
}



}

       


   /* private void DisplayData()
    {
        string sqlselect = "select * from gym";
        var data = DbConnection.GetTableByQuery(sqlselect);
        dataGridView1.DataSource = data;
    }

   

   
}          
}










        /*public Members()
        {
            InitializeComponent();
            Con = new Functions();
            ShowMembers();
            GetTrainers();
            GetMemberships();
        }
        private void ShowMembers()
        {
            string Query = "Select * From MembersTbl";
            dgvMembersList.DataSource = Con.getData(Query);
        }
        private void GetTrainers()
        {
            string Query = "Select * from TrainersTbl";
            cboMTrainer.DisplayMember = Con.getData(Query).Columns["TName"].ToString();
            cboMTrainer.ValueMember = Con.getData(Query).Columns["TId"].ToString();
            cboMTrainer.DataSource = Con.getData(Query);

        }
        private void GetMemberships()
        {
            string Query = "Select * from MembershipsTbl";
            cboMTrainingLevel.DisplayMember = Con.getData(Query).Columns["TrainingLevel"].ToString();
            cboMTrainingLevel.ValueMember = Con.getData(Query).Columns["MembershipId"].ToString();
            cboMTrainingLevel.DataSource = Con.getData(Query);

        }
      





       

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMName.Text == "" || txtPhoneNo.Text == "" || cboMGender.SelectedIndex == -1 || dtpMDOB.Text == "" || dtpMJoinDate.Text == "" || cboMTrainingLevel.SelectedIndex == -1 || txtMAddrs.Text == "" || cboMTiming.SelectedIndex == -1 || cboMTrainer.SelectedIndex == -1 || cboMStatus.SelectedIndex == -1 || cboMTrainer.SelectedIndex == -1)

                {
                    MessageBox.Show("Missing Data!!!");

                }
                else
                {
                    string MName = txtMName.Text;
                    string MGender = cboMGender.SelectedItem.ToString();
                    string MDOB = dtpMDOB.Value.Date.ToString();
                    string MJoinDate = dtpMJoinDate.Value.Date.ToString();
                    int MTrainingLevel = Convert.ToInt32(cboMTrainingLevel.SelectedValue.ToString());
                    int MTrainer = Convert.ToInt32(cboMTrainer.SelectedValue.ToString());
                    string MPhoneNo = txtPhoneNo.Text;
                    string MTiming = cboMTiming.SelectedItem.ToString();
                    string MStatus = cboMStatus.SelectedItem.ToString();
                    string MAddrs = txtMAddrs.Text;
                    string Query = "insert into MembersTbl values('{0}','{1}','{2}','{3}',{4},{5},'{6}','{7}','{8}','{9}')";
                    Query = string.Format(Query, MName, MGender, MDOB, MJoinDate, MTrainingLevel, MTrainer, MPhoneNo, MTiming, MStatus, MAddrs);
                    Con.setData(Query);
                    ShowMembers();
                    Reset();
                    MessageBox.Show("Member Added!!!");


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" || txtPhoneNo.Text == "" ||  txtDo.Text == "" || dtpMJoinDate.Text == "" || cboMTrainingLevel.SelectedIndex == -1 || txtMAddrs.Text == "" || cboMTiming.Text == "" || cboMTrainer.SelectedIndex == -1)
1 ||
                {
                    MessageBox.Show("Missing Data!!!");

                }
                else
                {
                    string MName = txtMName.Text;
                    string MGender = cboMGender.SelectedItem.ToString();
                    string MDOB = dtpMDOB.Value.Date.ToString();
                    string MJoinDate = dtpMJoinDate.Value.Date.ToString();
                    int MTrainingLevel = Convert.ToInt32(cboMTrainingLevel.SelectedValue.ToString());
                    int MTrainer = Convert.ToInt32(cboMTrainer.SelectedValue.ToString());
                    string MPhoneNo = txtPhoneNo.Text;
                    string MTiming = cboMTiming.SelectedItem.ToString();
                    string MStatus = cboMStatus.SelectedItem.ToString();
                    string MAddrs = txtMAddrs.Text;
                    string Query = "update  MembersTbl set MName = '{0}', MGender ='{1}', MDOB = '{2}', MJoinDate = '{3}', MTrainingLevel = {4}, MTrainer = '{5}', MPhoneNo = '{6}', MTiming = '{7}', MStatus = '{8}',MAddrs = '{9}' where MemberId = '{10}'";
                    Query = string.Format(Query, MName, MGender, MDOB, MJoinDate, MTrainingLevel, MTrainer, MPhoneNo, MTiming, MStatus, MAddrs, key);
                    Con.setData(Query);
                    ShowMembers();
                    Reset();
                    MessageBox.Show("Member Updated!!!");


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (key == 0)
                {
                    MessageBox.Show("Select a Member!!!");
                }
                else
                {

                    string Query = "Delete from MembersTbl where MemberId = {0}";
                    Query = string.Format(Query, key);
                    Con.setData(Query);
                    ShowMembers();
                    MessageBox.Show("Member Deleted!!!");
                    Reset();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}

*/