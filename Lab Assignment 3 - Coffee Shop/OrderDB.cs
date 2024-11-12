using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Lab_Assignment_3___Coffee_Shop
{
    class OrderDB
    {
        private string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../CoffeeShop.accdb;";

        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataAdapter myDataAdapter;
        OleDbDataReader myDataReader;

        private string queryString;

        DataSet orderDataSet, dateDataSet, priceDataSet;

        DataTable orderTable;
        public void InsertItemStatment(int ID, string customerName, string customerPhoneNumber, string customerAddress, string orderType, double tip, DateTime dateAndTime, double sale, double totalCost)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "INSERT INTO Order ([ID], [CustomerName], [CustomerPhone], [CustomerAddress], [OrderType], [Tip]), [Qty], [DateAndTime], [Sale], [TotalCost]" +
                        "VALUES ('" + ID + "','" + customerName + "','" + customerPhoneNumber + "','" + customerAddress + "','" + orderType + "','" + tip + "','"+dateAndTime + "','"+ sale + "','" +totalCost+ "')";
            myCommand = new OleDbCommand(queryString, myConnection);
            //myDataAdapter = new OleDbDataAdapter(myCommand);
            try
            {
                myConnection.Open();
                myDataAdapter.Update(orderDataSet, "ItemsTable");
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {

            }
            catch (SystemException)
            {
                myConnection.Close();

            }
        }

        public DataTable LoadOrderTable()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT CustomerName, CustomerPhone, CustomerAddress, OrderType, Tip, Qty, DateAndTime, Sale, TotalCost FROM Order"; 

            myCommand = new OleDbCommand(queryString, myConnection);
            myDataAdapter = new OleDbDataAdapter(myCommand);

            orderDataSet = new DataSet("OrderTable");

            myDataAdapter.Fill(orderDataSet, "OrderTable");
            return orderDataSet.Tables["OrderTable"];
        }

        public DataTable LoadEverythingOrderTable()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM Order"; 

            myCommand = new OleDbCommand(queryString, myConnection);
            myDataAdapter = new OleDbDataAdapter(myCommand);

            orderDataSet = new DataSet("OrderTable");

            myDataAdapter.Fill(orderDataSet, "OrderTable");
            return orderDataSet.Tables["OrderTable"];
        }

        // using the method for the combobox to search
        public DataTable LoadOnlySearchPriceTable(double price)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM Order Where Price ='" + price + "'";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            orderDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(orderDataSet, "ItemsTable");

            return orderDataSet.Tables["ItemsTable"];
        }

        // using the method for the combobox to search
        public DataTable LoadOnlySearchDateTable(string selectCategory)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM Item Where Category ='" + selectCategory + "'";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            orderDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(orderDataSet, "ItemsTable");

            return orderDataSet.Tables["ItemsTable"];
        }
    }
}
