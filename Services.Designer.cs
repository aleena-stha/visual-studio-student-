namespace GymFrm
{
    partial class Services
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTrainingType = new System.Windows.Forms.ComboBox();
            this.txtSwimmingCost = new System.Windows.Forms.TextBox();
            this.txtSaunaused = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCoachinghrs = new System.Windows.Forms.TextBox();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.labelTrainingType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sauna Used";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Swimming Used";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // comboTrainingType
            // 
            this.comboTrainingType.FormattingEnabled = true;
            this.comboTrainingType.Items.AddRange(new object[] {
            "Begineer",
            "Intermediate",
            "Expert"});
            this.comboTrainingType.Location = new System.Drawing.Point(137, 211);
            this.comboTrainingType.Name = "comboTrainingType";
            this.comboTrainingType.Size = new System.Drawing.Size(120, 21);
            this.comboTrainingType.TabIndex = 23;
            // 
            // txtSwimmingCost
            // 
            this.txtSwimmingCost.Location = new System.Drawing.Point(137, 158);
            this.txtSwimmingCost.Name = "txtSwimmingCost";
            this.txtSwimmingCost.Size = new System.Drawing.Size(120, 20);
            this.txtSwimmingCost.TabIndex = 36;
            // 
            // txtSaunaused
            // 
            this.txtSaunaused.Location = new System.Drawing.Point(137, 111);
            this.txtSaunaused.Name = "txtSaunaused";
            this.txtSaunaused.Size = new System.Drawing.Size(120, 20);
            this.txtSaunaused.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Coaching hours";
            // 
            // txtCoachinghrs
            // 
            this.txtCoachinghrs.Location = new System.Drawing.Point(137, 256);
            this.txtCoachinghrs.Name = "txtCoachinghrs";
            this.txtCoachinghrs.Size = new System.Drawing.Size(120, 20);
            this.txtCoachinghrs.TabIndex = 39;
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(24, 60);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(63, 13);
            this.labelCustomerId.TabIndex = 40;
            this.labelCustomerId.Text = "Customer Id";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(137, 60);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerId.TabIndex = 41;
            // 
            // labelTrainingType
            // 
            this.labelTrainingType.AutoSize = true;
            this.labelTrainingType.Location = new System.Drawing.Point(24, 211);
            this.labelTrainingType.Name = "labelTrainingType";
            this.labelTrainingType.Size = new System.Drawing.Size(72, 13);
            this.labelTrainingType.TabIndex = 42;
            this.labelTrainingType.Text = "Training Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Customer Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(137, 17);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(120, 20);
            this.txtCustomerName.TabIndex = 44;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(12, 310);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.Size = new System.Drawing.Size(719, 170);
            this.dataGridViewSearch.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelTrainingType);
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.labelCustomerId);
            this.groupBox1.Controls.Add(this.txtCoachinghrs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSaunaused);
            this.groupBox1.Controls.Add(this.txtSwimmingCost);
            this.groupBox1.Controls.Add(this.comboTrainingType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(191, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 301);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewSearch);
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTrainingType;
        private System.Windows.Forms.TextBox txtSwimmingCost;
        private System.Windows.Forms.TextBox txtSaunaused;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCoachinghrs;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label labelTrainingType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}