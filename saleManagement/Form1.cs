using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           
        private void itemMenu_Click(object sender, EventArgs e)
        {
            item formItem = new item();
            formItem.ShowDialog();
        }

        private void receiptMenu_Click(object sender, EventArgs e)
        {
            receipt formReceipt = new receipt();
            formReceipt.ShowDialog();
        }
    }
}
