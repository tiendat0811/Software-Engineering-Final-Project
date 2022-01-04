
namespace saleManagement
{
    partial class Form1
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
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDeliveryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDeliveryBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomingStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outgoingStocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenu,
            this.customerToolStripMenuItem,
            this.receiptMenu,
            this.ordersToolStripMenuItem,
            this.deliveryBillToolStripMenuItem,
            this.statisticalToolStripMenuItem,
            this.reneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.createReceiptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createReceiptToolStripMenuItem.Text = "Create receipt";
            // 
            // viewReceiptToolStripMenuItem
            // 
            this.viewReceiptToolStripMenuItem.Name = "viewReceiptToolStripMenuItem";
            this.viewReceiptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewReceiptToolStripMenuItem.Text = "View receipt";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.viewOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createOrderToolStripMenuItem.Text = "Create order";
            // 
            // viewOrdersToolStripMenuItem
            // 
            this.viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            this.viewOrdersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewOrdersToolStripMenuItem.Text = "View orders";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.viewCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createCustomerToolStripMenuItem.Text = "Create customer";
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewCustomerToolStripMenuItem.Text = "View customer";
            // 
            // deliveryBillToolStripMenuItem
            // 
            this.deliveryBillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDeliveryBillToolStripMenuItem,
            this.viewDeliveryBillToolStripMenuItem});
            this.deliveryBillToolStripMenuItem.Name = "deliveryBillToolStripMenuItem";
            this.deliveryBillToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.deliveryBillToolStripMenuItem.Text = "Delivery Bill";
            // 
            // createDeliveryBillToolStripMenuItem
            // 
            this.createDeliveryBillToolStripMenuItem.Name = "createDeliveryBillToolStripMenuItem";
            this.createDeliveryBillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createDeliveryBillToolStripMenuItem.Text = "Create delivery bill";
            // 
            // viewDeliveryBillToolStripMenuItem
            // 
            this.viewDeliveryBillToolStripMenuItem.Name = "viewDeliveryBillToolStripMenuItem";
            this.viewDeliveryBillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.incomingStocksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.incomingStocksToolStripMenuItem.Text = "Incoming stocks";
            // 
            // outgoingStocksToolStripMenuItem
            // 
            this.outgoingStocksToolStripMenuItem.Name = "outgoingStocksToolStripMenuItem";
            this.outgoingStocksToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.outgoingStocksToolStripMenuItem.Text = "Outgoing stocks";
            // 
            // reneToolStripMenuItem
            // 
            this.reneToolStripMenuItem.Name = "reneToolStripMenuItem";
            this.reneToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.reneToolStripMenuItem.Text = "Revenue monthly";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDeliveryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDeliveryBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomingStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outgoingStocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reneToolStripMenuItem;
    }
}

