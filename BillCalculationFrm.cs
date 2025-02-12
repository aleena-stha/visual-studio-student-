using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace GymFrm
{
    public partial class BillCalculationFrm : Form
    {
        private const double BeginnerTrainingCost = 1000.00;

        private const double IntermediateTrainingCost = 2000.00;

        private const double EliteTrainingCost = 3000.00;

        private const double PrivateTrainingCostPerHour = 500.00;

        private const double SaunaSessionCost = 1500.00;

        private const double SwimmingSessionCost = 500.00;



        public BillCalculationFrm()
        {
            InitializeComponent();


        }
        private double GetTrainingCost(string plan)
        {
            switch (plan.ToLower())
            {
                case "BegineerTrainingCost":
                    return 1000.00;
                case "IntermediateTrainingCost":
                    return 2000.00;
                case "EliteTrainingCost":
                    return 3000.00;
                default:
                    MessageBox.Show("Invalid training plan. Using basic plan cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1000.00;
            }
        }
        private void BtnCalculateBill_Click(object sender, EventArgs e)
        {


            // Get user inputs

            /* decimal trainingCost = 0;

             // Calculate cost based on training level

             string trainingLevel = comboTrainingType.SelectedItem.ToString();

             switch (trainingLevel)

             {

                 case "Beginner":

                     trainingCost += BeginnerTrainingCost;

                     break;

                 case "Intermediate":

                     totalCost += IntermediateTrainingCost;

                     break;

                 case "Elite":

                     totalCost += EliteTrainingCost;

                     break;

                 default:

                     MessageBox.Show("Please select a valid training level.");

                     return;
             }
            */

            string trainingPlan = comboTrainingType.SelectedItem.ToString();

            int SaunaUsed = Convert.ToInt32(txtSaunaused.Text);
            int privateCoachingHours = Convert.ToInt32(txtCoachingHours.Text);
            int SwimmingUsed = Convert.ToInt32(txtSwimmingUsed.Text);
            int PlanFee = Convert.ToInt32(txtSwimmingUsed.Text);
            // Constants (adjust as needed)
            double saunaCost = SaunaUsed * SaunaSessionCost;



            double privateCoachingCost = privateCoachingHours * PrivateTrainingCostPerHour;
            double SaunaCost = SaunaUsed * SaunaSessionCost;
            double SwimmingCost = SwimmingUsed * SwimmingSessionCost;
            // Calculate total cost
            double totalCost = GetTrainingCost(trainingPlan) + saunaCost + privateCoachingCost + SwimmingSessionCost;

            // Display results

            txtResult.Clear();

            txtResult.Text += "\r\n";

            txtResult.Text += "      GYM FORM FEES RECEIPT SYSTEM    \r \n";

            txtResult.Text += "\r\n";

            txtResult.Text += "Date: " + DateTime.Now + "\r\n\n";

            txtResult.Text += "ClientID: " + txtClientId.Text + "\r\n\n";

            txtResult.Text += "Payment Date: " + getDate.Text + "\r\n\n";


            txtResult.Text += $"Customer: {customer_id}\r\n\n";

            txtResult.Text += $"Training Plan : ${GetTrainingCost(trainingPlan):F2}\r\n\n";
            txtResult.Text += $"Training Plan Cost: $ {(trainingPlan): $(trainingcost:F2)}\r\n\n";


            txtResult.Text += $"Swimming Cost: ${SwimmingCost:F2}\r\n\n";
            txtResult.Text += $"Sauna Cost: ${saunaCost:F2}\r\n\n";
            txtResult.Text += $"Private Coaching Cost: ${privateCoachingCost:F2} \r\n\n";
            txtResult.Text += $"Total Cost for the Month: ${totalCost:F2}\r\n\n";
            txtResult.Text += "Signature: Admin";


        }

        private void btnWeightDiff_Click(object sender, EventArgs e)
        {
            // Get initial weight (IW) and current weight (CW) from user input

            // Get current weight and target weight from user input
            double initialWeight = Convert.ToDouble(txtInitialWeight.Text);
            double CurrentWeight = Convert.ToDouble(txtCurrentWeight.Text);


            // Calculate weight difference
            double weightDifference = CurrentWeight - initialWeight;

            // Display the result
            if (weightDifference > 0)
                resultLabel.Text = $"You've gained {Math.Abs(weightDifference):F2} kg.";

            else if (weightDifference < 0)
                resultLabel.Text = $"You've lost {Math.Abs(weightDifference):F2} kg.";
            else
                resultLabel.Text = "Your weight remains unchanged.";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtInitialWeight.Clear();

            txtCoachingHours.Clear();
            txtCurrentWeight.Clear();

            txtSwimmingUsed.Clear();
            txtSaunaused.Clear();
        }

        private void comboTrainingType_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedPlan = comboTrainingType.SelectedItem.ToString();
            string price = "";
            if (selectedPlan == "BegineerTrainingCost")
            {

                price = "1000";
            }
            else if (selectedPlan == "IntermediateTrainingCost")
            {

                price = "2000";
            }
            else if (selectedPlan == "EliteTrainingCost")
            {

                price = "3000";
            }


            txtPlan.Text = price;
        }

    }

}

       /* static void Main(string[] args)
        {
            // Define training plan names and prices
            string[] trainingPlans = { "Beginner", "Intermediate", "Elite" };
            double[] planPrices = { 1000, 2000, 3000 };

            // Display available training plans
            Console.WriteLine("Available Training Plans:");
            for (int i = 0; i < trainingPlans.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {trainingPlans[i]} - ${planPrices[i]:F2}");


            }



            // Get user input (select a plan)
            Console.Write("Enter the number corresponding to your desired training plan: ");
            int selectedPlanIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            // Validate user input
            if (selectedPlanIndex >= 0 && selectedPlanIndex < trainingPlans.Length)
            {
                string selectedPlan = trainingPlans[selectedPlanIndex];
                double selectedPrice = planPrices[selectedPlanIndex];
                Console.WriteLine($"You've selected the {selectedPlan} plan. Price: £{selectedPrice:F2}");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose a valid training plan.");
            }
        }
    }
}
    

    /*private double TrainingPlanCost(string plan)
      {
          switch (plan.ToSelected())
          {
              case "Begineer":
                  return 1000.00;
              case "Intermediate":
                  return 2000.00;
              case "Elite":
                  return 3000.00;
              default:
                  MessageBox.Show("Invalid training plan. Using basic plan cost.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return 1000.00;
          }
      }
    */



 
        
     



    /*public partial class Payment : Form

    {

        private const decimal BeginnerTrainingCost = 1000;

        private const decimal IntermediateTrainingCost = 2000;

        private const decimal EliteTrainingCost = 3000;

        private const decimal PrivateTrainingCostPerHour = 500;

        private const decimal SaunaSessionCost = 1500;

        private const decimal SwimmingSessionCost = 500;

        private const decimal TrainingCostPerHour = 1500;

       

        private void btnTotal_Cost_Click(object sender, EventArgs e)

        {

            decimal totalCost = 0;

            // Calculate cost based on training level

            string trainingLevel = cmbTraining_level.SelectedItem.ToString();

            switch (trainingLevel)

            {

                case "Beginner":

                    totalCost += BeginnerTrainingCost;

                    break;

                case "Intermediate":

                    totalCost += IntermediateTrainingCost;

                    break;

                case "Elite":

                    totalCost += EliteTrainingCost;

                    break;

                default:

                    MessageBox.Show("Please select a valid training level.");

                    return;

            }

            // Add cost of private trainer hours

            int PrivateTrainingHours = (int)nudTraining_cost_hours.Value;

            // Add cost of sauna sessions

            int SaunaSession = (int)nudSauna_session.Value;

            totalCost += SaunaSessionCost * SaunaSession;

            // Add cost of swimming sessions

            int SwimmingSession = (int)nudSwimming_session.Value;

            totalCost += SwimmingSessionCost * SwimmingSession;

            // Display the total cost

            btnTotal_Cost.Text = $" Rs.{totalCost}";

        }

        private void btnGenerate_Bill_Click(object sender, EventArgs e)

        {

            txtResult.Clear();

            txtResult.Text += "\n";

            txtResult.Text += "      DYNAMO FITNESS FEES RECEIPT SYSTEM     \n";

            txtResult.Text += "\n";

            txtResult.Text += "Date: " + DateTime.Now + "\n\n";

            txtResult.Text += "ClientID: " + txtClient_ID.Text + "\n\n";

            txtResult.Text += "Payment Date: " + getdate.Text + "\n\n";

            txtResult.Text += "Training Level: " + cmbTraining_level.Text + "\n\n";

            txtResult.Text += "Sauna Session: " + nudSauna_session.Text + "\n\n";

            txtResult.Text += "Swimming Session: " + nudSauna_session.Text + "\n\n";

            txtResult.Text += "Training Cost Hours: " + nudSwimming_session.Text + "\n\n";

            txtResult.Text += "Private Training Hours: " + nudPrivate_training_hours.Text + "\n\n";

            txtResult.Text += "Signature: Smritith";

        }










        //Parse input values




//lblTotalCost.Text = $"Total Cost for the Month: ${totalCost:F2}";

//Display information in labels

// $"Customer: {customer_id}\r\n" +
//               $"Training Plan Cost: ${TrainingCost:F2}\r\n" +
//           $"Sauna Cost: ${saunaCost:F2}\r\n" +
//              $"Private Coaching Cost: ${privateCoachingCost:F2}\r\n" +







/*  private void BtnSearch_Click_1(object sender, EventArgs e)
{
    {
        if (txtCustomerId.Text != "")
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ALEENA-44; database=gym ; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewCustomer where MID = " + txtCustomerId.Text + "";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridViewSearch.DataSource = DS.Tables[0];

        }
        else
        {
            MessageBox.Show("Please enter some Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
*/










      


