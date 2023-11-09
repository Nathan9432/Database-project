namespace InterviewProject_Net
{
	partial class CreateOrderForm
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
			this.itemNumberTextBox = new System.Windows.Forms.TextBox();
			this.shipDateTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.quantityTextBox = new System.Windows.Forms.TextBox();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.totalTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.orderNameTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ship Date";
			// 
			// itemNumberTextBox
			// 
			this.itemNumberTextBox.Location = new System.Drawing.Point(85, 6);
			this.itemNumberTextBox.Name = "itemNumberTextBox";
			this.itemNumberTextBox.Size = new System.Drawing.Size(100, 20);
			this.itemNumberTextBox.TabIndex = 0;
			// 
			// shipDateTextBox
			// 
			this.shipDateTextBox.Location = new System.Drawing.Point(85, 32);
			this.shipDateTextBox.Name = "shipDateTextBox";
			this.shipDateTextBox.Size = new System.Drawing.Size(100, 20);
			this.shipDateTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(191, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quantity";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(191, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Price";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(191, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Total";
			// 
			// quantityTextBox
			// 
			this.quantityTextBox.Location = new System.Drawing.Point(243, 4);
			this.quantityTextBox.Name = "quantityTextBox";
			this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
			this.quantityTextBox.TabIndex = 3;
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(243, 30);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(100, 20);
			this.priceTextBox.TabIndex = 4;
			// 
			// totalTextBox
			// 
			this.totalTextBox.Location = new System.Drawing.Point(243, 56);
			this.totalTextBox.Name = "totalTextBox";
			this.totalTextBox.Size = new System.Drawing.Size(100, 20);
			this.totalTextBox.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(268, 82);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Order Name";
			// 
			// orderNameTextBox
			// 
			this.orderNameTextBox.Location = new System.Drawing.Point(85, 56);
			this.orderNameTextBox.Name = "orderNameTextBox";
			this.orderNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.orderNameTextBox.TabIndex = 2;
			// 
			// CreateOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 115);
			this.Controls.Add(this.orderNameTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.totalTextBox);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.quantityTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.shipDateTextBox);
			this.Controls.Add(this.itemNumberTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CreateOrderForm";
			this.Text = "CreateOrderForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox itemNumberTextBox;
		private System.Windows.Forms.TextBox shipDateTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox quantityTextBox;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.TextBox totalTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox orderNameTextBox;
	}
}