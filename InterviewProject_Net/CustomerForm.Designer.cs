using System.Windows.Forms;

namespace InterviewProject_Net
{
	partial class CustomerForm
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.interviewProjectDataSet = new InterviewProject_Net.InterviewProjectDataSet();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.createOrdersButton = new System.Windows.Forms.Button();
			this.addCustomerButton = new System.Windows.Forms.Button();
			this.updateCustomerButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.stateTextBox = new System.Windows.Forms.TextBox();
			this.zipTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.deleteCustomerButton = new System.Windows.Forms.Button();
			this.customersTableAdapter = new InterviewProject_Net.InterviewProjectDataSetTableAdapters.CustomersTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.interviewProjectDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.City,
            this.State,
            this.ZipCode});
			this.dataGridView1.DataSource = this.customersBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(12, 165);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(376, 123);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "ID";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.firstNameDataGridViewTextBoxColumn.Width = 79;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.lastNameDataGridViewTextBoxColumn.Width = 80;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// City
			// 
			this.City.DataPropertyName = "City";
			this.City.HeaderText = "City";
			this.City.Name = "City";
			this.City.ReadOnly = true;
			this.City.Visible = false;
			// 
			// State
			// 
			this.State.DataPropertyName = "State";
			this.State.HeaderText = "State";
			this.State.Name = "State";
			this.State.ReadOnly = true;
			this.State.Visible = false;
			// 
			// ZipCode
			// 
			this.ZipCode.DataPropertyName = "ZipCode";
			this.ZipCode.HeaderText = "ZipCode";
			this.ZipCode.Name = "ZipCode";
			this.ZipCode.ReadOnly = true;
			this.ZipCode.Visible = false;
			// 
			// customersBindingSource1
			// 
			this.customersBindingSource1.DataMember = "Customers";
			this.customersBindingSource1.DataSource = this.interviewProjectDataSet;
			// 
			// interviewProjectDataSet
			// 
			this.interviewProjectDataSet.DataSetName = "InterviewProjectDataSet";
			this.interviewProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataMember = "Customers";
			this.customersBindingSource.DataSource = this.interviewProjectDataSet;
			// 
			// createOrdersButton
			// 
			this.createOrdersButton.Location = new System.Drawing.Point(64, 136);
			this.createOrdersButton.Name = "createOrdersButton";
			this.createOrdersButton.Size = new System.Drawing.Size(81, 23);
			this.createOrdersButton.TabIndex = 6;
			this.createOrdersButton.Text = "Create Orders";
			this.createOrdersButton.UseVisualStyleBackColor = true;
			this.createOrdersButton.Click += new System.EventHandler(this.CreateOrdersButton_Click);
			// 
			// addCustomerButton
			// 
			this.addCustomerButton.Location = new System.Drawing.Point(151, 136);
			this.addCustomerButton.Name = "addCustomerButton";
			this.addCustomerButton.Size = new System.Drawing.Size(75, 23);
			this.addCustomerButton.TabIndex = 7;
			this.addCustomerButton.Text = "Add";
			this.addCustomerButton.UseVisualStyleBackColor = true;
			this.addCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
			// 
			// updateCustomerButton
			// 
			this.updateCustomerButton.Location = new System.Drawing.Point(232, 136);
			this.updateCustomerButton.Name = "updateCustomerButton";
			this.updateCustomerButton.Size = new System.Drawing.Size(75, 23);
			this.updateCustomerButton.TabIndex = 8;
			this.updateCustomerButton.Text = "Update";
			this.updateCustomerButton.UseVisualStyleBackColor = true;
			this.updateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "First Name";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(75, 6);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.firstNameTextBox.TabIndex = 0;
			this.firstNameTextBox.Enter += new System.EventHandler(this.FirstNameTextBox_Enter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(181, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Last Name";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(245, 6);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.lastNameTextBox.TabIndex = 1;
			this.lastNameTextBox.Enter += new System.EventHandler(this.LastNameTextBox_Enter);
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(75, 32);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(100, 20);
			this.addressTextBox.TabIndex = 2;
			this.addressTextBox.Enter += new System.EventHandler(this.AddressTextBox_Enter);
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(75, 58);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(100, 20);
			this.cityTextBox.TabIndex = 3;
			this.cityTextBox.Enter += new System.EventHandler(this.CityTextBox_Enter);
			// 
			// stateTextBox
			// 
			this.stateTextBox.Location = new System.Drawing.Point(75, 84);
			this.stateTextBox.Name = "stateTextBox";
			this.stateTextBox.Size = new System.Drawing.Size(100, 20);
			this.stateTextBox.TabIndex = 4;
			this.stateTextBox.Enter += new System.EventHandler(this.StateTextBox_Enter);
			// 
			// zipTextBox
			// 
			this.zipTextBox.Location = new System.Drawing.Point(75, 110);
			this.zipTextBox.Name = "zipTextBox";
			this.zipTextBox.Size = new System.Drawing.Size(100, 20);
			this.zipTextBox.TabIndex = 5;
			this.zipTextBox.Enter += new System.EventHandler(this.ZipTextBox_Enter);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Address";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "City";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "State";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Zip Code";
			// 
			// deleteCustomerButton
			// 
			this.deleteCustomerButton.Location = new System.Drawing.Point(313, 136);
			this.deleteCustomerButton.Name = "deleteCustomerButton";
			this.deleteCustomerButton.Size = new System.Drawing.Size(75, 23);
			this.deleteCustomerButton.TabIndex = 9;
			this.deleteCustomerButton.Text = "Delete";
			this.deleteCustomerButton.UseVisualStyleBackColor = true;
			this.deleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// CustomerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.deleteCustomerButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.zipTextBox);
			this.Controls.Add(this.stateTextBox);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.updateCustomerButton);
			this.Controls.Add(this.addCustomerButton);
			this.Controls.Add(this.createOrdersButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CustomerForm";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.CustomerForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.interviewProjectDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
		private InterviewProjectDataSet interviewProjectDataSet;
		private BindingSource customersBindingSource;
		private Button createOrdersButton;
		private Button addCustomerButton;
		private Button updateCustomerButton;
		private Label label1;
		private TextBox firstNameTextBox;
		private Label label2;
		private TextBox lastNameTextBox;
		private TextBox addressTextBox;
		private TextBox cityTextBox;
		private TextBox stateTextBox;
		private TextBox zipTextBox;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button deleteCustomerButton;
		private BindingSource customersBindingSource1;
		private InterviewProjectDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn City;
		private DataGridViewTextBoxColumn State;
		private DataGridViewTextBoxColumn ZipCode;
	}

}