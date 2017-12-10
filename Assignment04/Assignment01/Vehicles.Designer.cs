namespace Assignment01
{
    partial class Vehicles
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dailyRateLabel;
            System.Windows.Forms.Label mileageRateLabel;
            System.Windows.Forms.Label sizeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicles));
            this.button1 = new System.Windows.Forms.Button();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDataGridView = new System.Windows.Forms.DataGridView();
            this.dailyRateTextBox = new System.Windows.Forms.TextBox();
            this.mileageRateTextBox = new System.Windows.Forms.TextBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dailyRateLabel = new System.Windows.Forms.Label();
            mileageRateLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyRateLabel
            // 
            dailyRateLabel.AutoSize = true;
            dailyRateLabel.Location = new System.Drawing.Point(12, 45);
            dailyRateLabel.Name = "dailyRateLabel";
            dailyRateLabel.Size = new System.Drawing.Size(59, 13);
            dailyRateLabel.TabIndex = 7;
            dailyRateLabel.Text = "Daily Rate:";
            // 
            // mileageRateLabel
            // 
            mileageRateLabel.AutoSize = true;
            mileageRateLabel.Location = new System.Drawing.Point(12, 71);
            mileageRateLabel.Name = "mileageRateLabel";
            mileageRateLabel.Size = new System.Drawing.Size(73, 13);
            mileageRateLabel.TabIndex = 9;
            mileageRateLabel.Text = "Mileage Rate:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(12, 15);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 11;
            sizeLabel.Text = "Size:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(CarsLibrary.Vehicle);
            // 
            // vehicleDataGridView
            // 
            this.vehicleDataGridView.AutoGenerateColumns = false;
            this.vehicleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vehicleDataGridView.DataSource = this.vehicleBindingSource;
            this.vehicleDataGridView.Location = new System.Drawing.Point(1, 106);
            this.vehicleDataGridView.Name = "vehicleDataGridView";
            this.vehicleDataGridView.Size = new System.Drawing.Size(588, 220);
            this.vehicleDataGridView.TabIndex = 7;
            // 
            // dailyRateTextBox
            // 
            this.dailyRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "CarSize1.DailyRate", true));
            this.dailyRateTextBox.Location = new System.Drawing.Point(91, 42);
            this.dailyRateTextBox.Name = "dailyRateTextBox";
            this.dailyRateTextBox.Size = new System.Drawing.Size(121, 20);
            this.dailyRateTextBox.TabIndex = 8;
            // 
            // mileageRateTextBox
            // 
            this.mileageRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "CarSize1.MileageRate", true));
            this.mileageRateTextBox.Location = new System.Drawing.Point(91, 68);
            this.mileageRateTextBox.Name = "mileageRateTextBox";
            this.mileageRateTextBox.Size = new System.Drawing.Size(121, 20);
            this.mileageRateTextBox.TabIndex = 10;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "CarSize1.Size", true));
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Economy",
            "Luxury",
            "Mid-size"});
            this.sizeComboBox.Location = new System.Drawing.Point(91, 12);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.sizeComboBox.TabIndex = 12;
            this.sizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sizeComboBox_SelectedIndexChanged_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Inv_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Inv_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Manuf_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Manuf_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 348);
            this.Controls.Add(this.vehicleDataGridView);
            this.Controls.Add(dailyRateLabel);
            this.Controls.Add(this.dailyRateTextBox);
            this.Controls.Add(mileageRateLabel);
            this.Controls.Add(this.mileageRateTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.DataGridView vehicleDataGridView;
        private System.Windows.Forms.TextBox dailyRateTextBox;
        private System.Windows.Forms.TextBox mileageRateTextBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}