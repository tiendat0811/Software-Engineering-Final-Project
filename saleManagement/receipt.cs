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
    public partial class receipt : Form
    {
        SqlConnection con = new SqlConnection();
        String strConn = ConfigurationManager.ConnectionStrings["dbconfig"].ConnectionString;

        public receipt()
        {
            InitializeComponent();
            con.ConnectionString = strConn;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            this.itemGridView.Rows.Add(tbIdItem.Text, tbNameItem.Text, tbQuantity.Text, tbPrice.Text);
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            string idReceipt = tbIdReceipt.Text;
            string idAccountant = tbIdAccountant.Text;
            var createDates = createDate.Value;
            int year = createDates.Year;
            int month = createDates.Month;
            int day = createDates.Day;

            string creationDate = string.Format("{0}/{1}/{2}", month, day, year);
            addReceipt(idReceipt, idAccountant, creationDate);
            for (int i = 0; i < itemGridView.Rows.Count; i++)
            {
                string idItem = itemGridView.Rows[i].Cells[0].Value.ToString();
                string nameItem = itemGridView.Rows[i].Cells[1].Value.ToString();
                string quantity = itemGridView.Rows[i].Cells[2].Value.ToString();
                string price = itemGridView.Rows[i].Cells[3].Value.ToString();
                if (isItemExist(idItem))
                {
                    addDetailReceipt(idReceipt, idItem, quantity, price);
                    updateInventory(idItem, quantity);
                }
                else
                {
                    addNewItem(idItem, nameItem);
                    addDetailReceipt(idReceipt, idItem, quantity, price);
                    updateInventory(idItem, quantity);
                }
            }
            updateTotalPrice(idReceipt);
            clearInput();
        }

        private void clearInput()
        {
            tbIdReceipt.Text = "";
            tbIdAccountant.Text = "";
            createDate.Value = DateTime.Now;
            tbIdItem.Text = "";
            tbNameItem.Text = "";
            tbQuantity.Text = "";
            tbPrice.Text = "";

            itemGridView.Rows.Clear();
            itemGridView.Refresh();
        }

        //GET FROM DATABASE
        private Boolean isItemExist(String idItem)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "Select count(*) from item where idItem = '"+ idItem +"'";

            command = new SqlCommand(sql, con);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0);
            }

            int count = Int32.Parse(Output);
            dataReader.Close();
            command.Dispose();
            con.Close();
            if (count > 0)
                return true;
            else
                return false;
        }

        //INSERT TO DATABASE
        private void addReceipt(string idReceipt, string idAccountant, string creationDate)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            sql = "Insert into receipt values('" + idReceipt + "','" + idAccountant + "','" + creationDate.ToString()+"','')";
            MessageBox.Show(sql);
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }
        private void addDetailReceipt(string idReceipt, string idItem, string quantity, string price)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "Insert into detailReceipt values('" + idReceipt + "','" + idItem + "'," + quantity+","+price+")";

            command = new SqlCommand(sql, con);

            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        private void addNewItem(string idItem, string nameItem)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "Insert into item values('" + idItem + "','" + nameItem + "', 0)"; 

            command = new SqlCommand(sql, con);

            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        //UPDATE TO DATABASE
        private void updateInventory(string idItem, string quantity)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "Update item set inventory = "+quantity+"where idItem = '"+idItem+"'";

            command = new SqlCommand(sql, con);

            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }

        private void updateTotalPrice(string idReceipt)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";

            sql = "update receipt set totalPrice = (select sum(price * quantity) as amount from detailReceipt where idReceipt = '"+idReceipt+ "') where idReceipt = '" + idReceipt + "'";

            command = new SqlCommand(sql, con);

            adapter.UpdateCommand = new SqlCommand(sql, con);
            adapter.UpdateCommand.ExecuteNonQuery();

            command.Connection.Close();
            command.Dispose();
            con.Close();
        }
    }
}
