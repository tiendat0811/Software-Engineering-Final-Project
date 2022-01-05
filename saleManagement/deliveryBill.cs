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
        private void orderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.orderGridView.Rows[e.RowIndex];
            tbIdOrder.Text = row.Cells[0].Value.ToString();
        }

        private void btnCreateDeliveryBill_Click(object sender, EventArgs e)
        {
            string idDeliveryBill = tbIdDeliveryBill.Text;
            string idAccountant = tbIdAccountant.Text;
            string idOrder = tbIdOrder.Text;

            var createDates = createDate.Value;
            int year = createDates.Year;
            int month = createDates.Month;
            int day = createDates.Day;

            string creationDate = string.Format("{0}/{1}/{2}", month, day, year);

            string orderStatus = "";
            if (rbBeingTransported.Checked)
            {
                orderStatus = "being transported";
            }
            else
            {
                orderStatus = "delivered";
            }

            string paymentStatus = "";
            if (rbPaid.Checked)
            {
                paymentStatus = "paid";
            }
            else
            {
                paymentStatus = "unpaid";
            }

            createDeliveryBill(idDeliveryBill, idOrder, idAccountant, creationDate, orderStatus, paymentStatus);
        }

        private void createDeliveryBill(string idDeliveryBill, string idOrder, string idAccountant, string creationDate, string orderStatus, string paymentStatus)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "insert into deliveryBill values ('"+idDeliveryBill+"', '"+idOrder+ "', '"+idAccountant+ "', '"+creationDate+ "', '"+orderStatus+ "' , '"+paymentStatus+"')";
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }
    }
}
