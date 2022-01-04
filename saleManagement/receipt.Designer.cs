
namespace saleManagement
{
    partial class receipt
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
            this.createDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdAccountant = new System.Windows.Forms.TextBox();
            this.tbIdReceipt = new System.Windows.Forms.TextBox();
            this.tbIdItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.itemGridView = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNameItem = new System.Windows.Forms.TextBox();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Receipt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Accnoutant";
            // 
            // createDate
            // 
            this.createDate.Location = new System.Drawing.Point(146, 83);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(200, 22);
            this.createDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creation Date";
            // 
            // tbIdAccountant
            // 
            this.tbIdAccountant.Location = new System.Drawing.Point(146, 51);
            this.tbIdAccountant.Name = "tbIdAccountant";
            this.tbIdAccountant.Size = new System.Drawing.Size(200, 22);
            this.tbIdAccountant.TabIndex = 4;
            // 
            // tbIdReceipt
            // 
            this.tbIdReceipt.Location = new System.Drawing.Point(146, 12);
            this.tbIdReceipt.Name = "tbIdReceipt";
            this.tbIdReceipt.Size = new System.Drawing.Size(200, 22);
            this.tbIdReceipt.TabIndex = 5;
            // 
            // tbIdItem
            // 
            this.tbIdItem.Location = new System.Drawing.Point(147, 197);
            this.tbIdItem.Name = "tbIdItem";
            this.tbIdItem.Size = new System.Drawing.Size(200, 22);
            this.tbIdItem.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Item ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price per item";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(74, 342);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(167, 30);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item to list";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // itemGridView
            // 
            this.itemGridView.AllowUserToAddRows = false;
            this.itemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.nameItem,
            this.quantity,
            this.price});
            this.itemGridView.Location = new System.Drawing.Point(25, 389);
            this.itemGridView.Name = "itemGridView";
            this.itemGridView.RowHeadersWidth = 51;
            this.itemGridView.RowTemplate.Height = 24;
            this.itemGridView.Size = new System.Drawing.Size(613, 348);
            this.itemGridView.TabIndex = 14;
            // 
            // idItem
            // 
            this.idItem.HeaderText = "ID Item";
            this.idItem.MinimumWidth = 6;
            this.idItem.Name = "idItem";
            this.idItem.ReadOnly = true;
            this.idItem.Width = 125;
            // 
            // nameItem
            // 
            this.nameItem.HeaderText = "Name Item";
            this.nameItem.MinimumWidth = 6;
            this.nameItem.Name = "nameItem";
            this.nameItem.ReadOnly = true;
            this.nameItem.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 80;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name Item";
            // 
            // tbNameItem
            // 
            this.tbNameItem.Location = new System.Drawing.Point(147, 233);
            this.tbNameItem.Name = "tbNameItem";
            this.tbNameItem.Size = new System.Drawing.Size(200, 22);
            this.tbNameItem.TabIndex = 15;
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.Location = new System.Drawing.Point(418, 186);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(187, 67);
            this.btnAddReceipt.TabIndex = 17;
            this.btnAddReceipt.Text = "Create Receipt";
            this.btnAddReceipt.UseVisualStyleBackColor = true;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(147, 273);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 22);
            this.tbQuantity.TabIndex = 18;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(147, 305);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(200, 22);
            this.tbPrice.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "You should add the item to the list before creating the receipt";
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 758);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.btnAddReceipt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNameItem);
            this.Controls.Add(this.itemGridView);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIdItem);
            this.Controls.Add(this.tbIdReceipt);
            this.Controls.Add(this.tbIdAccountant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "receipt";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.itemGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker createDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdAccountant;
        private System.Windows.Forms.TextBox tbIdReceipt;
        private System.Windows.Forms.TextBox tbIdItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView itemGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNameItem;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label8;
    }
}