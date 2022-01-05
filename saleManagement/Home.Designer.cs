
namespace saleManagement
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDeliveryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDeliveryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outgoingStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnDeliveryBill = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenu,
            this.receiptMenu,
            this.deliveryBillToolStripMenuItem,
            this.statisticalToolStripMenuItem,
            this.reneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemMenu
            // 
            this.itemMenu.Name = "itemMenu";
            this.itemMenu.Size = new System.Drawing.Size(59, 24);
            this.itemMenu.Text = "Items";
            this.itemMenu.Click += new System.EventHandler(this.itemMenu_Click);
            // 
            // receiptMenu
            // 
            this.receiptMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReceiptToolStripMenuItem,
            this.viewReceiptToolStripMenuItem});
            this.receiptMenu.Name = "receiptMenu";
            this.receiptMenu.Size = new System.Drawing.Size(79, 24);
            this.receiptMenu.Text = "Receipts";
            this.receiptMenu.Click += new System.EventHandler(this.receiptMenu_Click);
            // 
            // createReceiptToolStripMenuItem
            // 
            this.createReceiptToolStripMenuItem.Name = "createReceiptToolStripMenuItem";
            this.createReceiptToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.createReceiptToolStripMenuItem.Text = "Create receipt";
            // 
            // viewReceiptToolStripMenuItem
            // 
            this.viewReceiptToolStripMenuItem.Name = "viewReceiptToolStripMenuItem";
            this.viewReceiptToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.viewReceiptToolStripMenuItem.Text = "View receipt";
            // 
            // deliveryBillToolStripMenuItem
            // 
            this.deliveryBillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDeliveryBillToolStripMenuItem,
            this.viewDeliveryBillToolStripMenuItem});
            this.deliveryBillToolStripMenuItem.Name = "deliveryBillToolStripMenuItem";
            this.deliveryBillToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.deliveryBillToolStripMenuItem.Text = "Delivery Bill";
            this.deliveryBillToolStripMenuItem.Click += new System.EventHandler(this.deliveryBillToolStripMenuItem_Click);
            // 
            // createDeliveryBillToolStripMenuItem
            // 
            this.createDeliveryBillToolStripMenuItem.Name = "createDeliveryBillToolStripMenuItem";
            this.createDeliveryBillToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.createDeliveryBillToolStripMenuItem.Text = "Create delivery bill";
            // 
            // viewDeliveryBillToolStripMenuItem
            // 
            this.viewDeliveryBillToolStripMenuItem.Name = "viewDeliveryBillToolStripMenuItem";
            this.viewDeliveryBillToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.viewDeliveryBillToolStripMenuItem.Text = "View delivery bill";
            // 
            // statisticalToolStripMenuItem
            // 
            this.statisticalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomingStocksToolStripMenuItem,
            this.outgoingStocksToolStripMenuItem});
            this.statisticalToolStripMenuItem.Name = "statisticalToolStripMenuItem";
            this.statisticalToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.statisticalToolStripMenuItem.Text = "Statistical";
            // 
            // incomingStocksToolStripMenuItem
            // 
            this.incomingStocksToolStripMenuItem.Name = "incomingStocksToolStripMenuItem";
            this.incomingStocksToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.incomingStocksToolStripMenuItem.Text = "Incoming stocks";
            // 
            // outgoingStocksToolStripMenuItem
            // 
            this.outgoingStocksToolStripMenuItem.Name = "outgoingStocksToolStripMenuItem";
            this.outgoingStocksToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.outgoingStocksToolStripMenuItem.Text = "Outgoing stocks";
            // 
            // reneToolStripMenuItem
            // 
            this.reneToolStripMenuItem.Name = "reneToolStripMenuItem";
            this.reneToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.reneToolStripMenuItem.Text = "Revenue monthly";
            this.reneToolStripMenuItem.Click += new System.EventHandler(this.reneToolStripMenuItem_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(65, 71);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(145, 43);
            this.btnItem.TabIndex = 1;
            this.btnItem.Text = "Item Management";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(252, 71);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(145, 43);
            this.btnReceipt.TabIndex = 2;
            this.btnReceipt.Text = "Receipt Management";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnDeliveryBill
            // 
            this.btnDeliveryBill.Location = new System.Drawing.Point(453, 71);
            this.btnDeliveryBill.Name = "btnDeliveryBill";
            this.btnDeliveryBill.Size = new System.Drawing.Size(145, 43);
            this.btnDeliveryBill.TabIndex = 3;
            this.btnDeliveryBill.Text = "Delivery Bill";
            this.btnDeliveryBill.UseVisualStyleBackColor = true;
            this.btnDeliveryBill.Click += new System.EventHandler(this.btnDeliveryBill_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Location = new System.Drawing.Point(155, 163);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(145, 43);
            this.btnStatistical.TabIndex = 4;
            this.btnStatistical.Text = "Statistical";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Location = new System.Drawing.Point(349, 163);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(145, 43);
            this.btnRevenue.TabIndex = 5;
            this.btnRevenue.Text = "Revenue Monthly";
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 279);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.btnDeliveryBill);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Sale Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemMenu;
        private System.Windows.Forms.ToolStripMenuItem receiptMenu;
        private System.Windows.Forms.ToolStripMenuItem createReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDeliveryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDeliveryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomingStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outgoingStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reneToolStripMenuItem;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnDeliveryBill;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Button btnRevenue;
    }
}

