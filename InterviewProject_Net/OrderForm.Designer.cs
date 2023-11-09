using System.Windows.Forms;

namespace InterviewProject_Net
{
	partial class OrderForm
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
			this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.interviewProjectDataSet = new InterviewProject_Net.InterviewProjectDataSet();
			this.orderDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.interviewProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderLabel = new System.Windows.Forms.Label();
			this.customerLabel = new System.Windows.Forms.Label();
			this.shipDateLabel = new System.Windows.Forms.Label();
			this.orderDetailsTableAdapter = new InterviewProject_Net.InterviewProjectDataSetTableAdapters.OrderDetailsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.interviewProjectDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.interviewProjectDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
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
            this.itemNumberDataGridViewTextBoxColumn,
            this.OrderId,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.orderDetailsBindingSource2;
			this.dataGridView1.Location = new System.Drawing.Point(12, 69);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(376, 219);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
			// 
			// itemNumberDataGridViewTextBoxColumn
			// 
			this.itemNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.itemNumberDataGridViewTextBoxColumn.DataPropertyName = "ItemNumber";
			this.itemNumberDataGridViewTextBoxColumn.HeaderText = "ItemNumber";
			this.itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
			this.itemNumberDataGridViewTextBoxColumn.Width = 89;
			// 
			// OrderId
			// 
			this.OrderId.DataPropertyName = "OrderId";
			this.OrderId.HeaderText = "OrderId";
			this.OrderId.Name = "OrderId";
			this.OrderId.Visible = false;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			this.quantityDataGridViewTextBoxColumn.Width = 71;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.Width = 56;
			// 
			// totalDataGridViewTextBoxColumn
			// 
			this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
			this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
			this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
			// 
			// orderDetailsBindingSource2
			// 
			this.orderDetailsBindingSource2.DataMember = "OrderDetails";
			this.orderDetailsBindingSource2.DataSource = this.interviewProjectDataSet;
			// 
			// interviewProjectDataSet
			// 
			this.interviewProjectDataSet.DataSetName = "InterviewProjectDataSet";
			this.interviewProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// orderDetailsBindingSource1
			// 
			this.orderDetailsBindingSource1.DataMember = "OrderDetails";
			this.orderDetailsBindingSource1.DataSource = this.interviewProjectDataSetBindingSource;
			// 
			// interviewProjectDataSetBindingSource
			// 
			this.interviewProjectDataSetBindingSource.DataSource = this.interviewProjectDataSet;
			this.interviewProjectDataSetBindingSource.Position = 0;
			// 
			// ordersBindingSource
			// 
			this.ordersBindingSource.DataMember = "Orders";
			this.ordersBindingSource.DataSource = this.interviewProjectDataSetBindingSource;
			// 
			// orderDetailsBindingSource
			// 
			this.orderDetailsBindingSource.DataMember = "OrderDetails";
			this.orderDetailsBindingSource.DataSource = this.interviewProjectDataSetBindingSource;
			// 
			// orderLabel
			// 
			this.orderLabel.AutoSize = true;
			this.orderLabel.Location = new System.Drawing.Point(12, 9);
			this.orderLabel.Name = "orderLabel";
			this.orderLabel.Size = new System.Drawing.Size(70, 13);
			this.orderLabel.TabIndex = 1;
			this.orderLabel.Text = "Order Name: ";
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Location = new System.Drawing.Point(12, 31);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(88, 13);
			this.customerLabel.TabIndex = 2;
			this.customerLabel.Text = "Customer Name: ";
			// 
			// shipDateLabel
			// 
			this.shipDateLabel.AutoSize = true;
			this.shipDateLabel.Location = new System.Drawing.Point(12, 53);
			this.shipDateLabel.Name = "shipDateLabel";
			this.shipDateLabel.Size = new System.Drawing.Size(60, 13);
			this.shipDateLabel.TabIndex = 3;
			this.shipDateLabel.Text = "Ship Date: ";
			// 
			// orderDetailsTableAdapter
			// 
			this.orderDetailsTableAdapter.ClearBeforeFill = true;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.shipDateLabel);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.orderLabel);
			this.Controls.Add(this.dataGridView1);
			this.Name = "OrderForm";
			this.Text = "OrderForm";
			this.Load += new System.EventHandler(this.OrderForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.interviewProjectDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.interviewProjectDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private void postInitialize(string query)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Id = '{1}'", identifier);
            var temp = dataGridView1.DataSource as BindingSource;
            string temp2 = string.Format("OrderId IN ({0})", query);
            temp.Filter = temp2;
        }

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource interviewProjectDataSetBindingSource;
		private InterviewProjectDataSet interviewProjectDataSet;
		private System.Windows.Forms.BindingSource ordersBindingSource;
		private System.Windows.Forms.BindingSource orderDetailsBindingSource;
		private System.Windows.Forms.BindingSource orderDetailsBindingSource1;
		private System.Windows.Forms.Label orderLabel;
		private System.Windows.Forms.Label customerLabel;
		private System.Windows.Forms.Label shipDateLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
		private BindingSource orderDetailsBindingSource2;
		private InterviewProjectDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
	}
}