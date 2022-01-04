using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleManagement
{
    public partial class deliveryBill : Form
    {
        SqlConnection con = new SqlConnection();
        String strConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;
        public deliveryBill()
        {
            InitializeComponent();
            con.ConnectionString = strConn;
            updateTotalPrice();
        }
        private void updateTotalPrice()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "UPDATE o SET totalPrice = COALESCE(de.amount, 0) FROM orders o LEFT JOIN (select ord.idOrder, sum(price * quantity) as amount from detailOrder do, orders ord where ord.idOrder = do.idOrder group by ord.idOrder) de ON de.idOrder = o.idOrder;";

            command = new SqlCommand(sql, con);

            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        private void deliveryBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleManagementDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.saleManagementDataSet.orders);

        }
    }
}
