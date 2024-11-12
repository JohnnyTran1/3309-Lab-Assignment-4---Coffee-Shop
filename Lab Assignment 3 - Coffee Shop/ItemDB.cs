using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Lab_Assignment_3___Coffee_Shop
{//Lecture slides - Databases
    class ItemDB
    {
        private string connectString = "provider=Microsoft.ACE.OLEDB.12.0; Data Source=../../CoffeeShop.accdb;";

        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataAdapter myDataAdapter;
        OleDbDataReader myDataReader;

        private string queryString;

        DataSet itemDataSet, categoryDataSet;

        DataTable itemTable;


        //insert the record
        public void InsertItemStatment(Food food)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "INSERT INTO Item ([Category], [Image], [ShortDescription], [LongDescription], [Price], [Cost])" +
                        "VALUES ('" + food.Category + "','" + food.Image + "','" + food.ShortDescription + "','" + food.LongDescription +"','" + food.Price + "','" + food.Cost + "')";
            myCommand = new OleDbCommand(queryString, myConnection);
            //myDataAdapter = new OleDbDataAdapter(myCommand);
            try
            {
                myConnection.Open();
                myDataAdapter.Update(itemDataSet, "ItemsTable");
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

        //frmEmployeeCreate, show all the fields but not ID
        public DataTable LoadItemTable()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT ID, ShortDescription, LongDescription, Category, Cost, Price, Image FROM Item";

            myCommand = new OleDbCommand(queryString, myConnection);
            myDataAdapter = new OleDbDataAdapter(myCommand);

            itemDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(itemDataSet, "ItemsTable");
            return itemDataSet.Tables["ItemsTable"];
        }

        //Deleting the record
        public void DeleteItem(int ID)
        {
            myConnection = new OleDbConnection(connectString);

            //queryString = "DELETE  FROM Item Where ID = '" + ID + "'";
            // TA helped me with this, I dont why this query works but not the one above it
             queryString = "DELETE FROM Item " + "WHERE ID = @ID; ";

            myCommand = new OleDbCommand(queryString, myConnection);

            myCommand.Parameters.AddWithValue("@ID", ID);

            try
            {
                //myDataAdapter = new OleDbDataAdapter(myCommand);
                myConnection.Open();
                //myDataAdapter.Update(itemDataSet, "ItemsTable");
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {

            }
            catch
            {
                myConnection.Close();

            }
        }

        //frmEmployeeCreate, show all the fields including the ID
        public DataTable LoadEverythingItemTable()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM Item";

            myCommand = new OleDbCommand(queryString, myConnection);
            myDataAdapter = new OleDbDataAdapter(myCommand);

            itemDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(itemDataSet, "ItemsTable");
            return itemDataSet.Tables["ItemsTable"];
        }

        // load up the combobox for the category
        public DataTable LoadCategoryTable()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT Distinct Category FROM Item";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            categoryDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(categoryDataSet, "ItemsTable");
            return categoryDataSet.Tables["ItemsTable"];
        }

        // using the method for the combobox to search
        public DataTable LoadOnlySearchCategoryTable(string selectCategory)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT * FROM Item Where Category ='" + selectCategory + "'";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            itemDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(itemDataSet, "ItemsTable");

            return itemDataSet.Tables["ItemsTable"];
        }
        
        //frmMenuDisplay that has a datagridview showing 3 columns
        public DataTable MenuDisplay()
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT ShortDescription, Category, Price FROM Item";

            myCommand = new OleDbCommand(queryString, myConnection);
            myDataAdapter = new OleDbDataAdapter(myCommand);

            itemDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(itemDataSet, "ItemsTable");
            return itemDataSet.Tables["ItemsTable"];
        }

        //frmMenuDisplay that has a datagridview showing 3 columns for the search, i wanted to make sure the datagridview's columns stay consist
        public DataTable LoadOnlySearchCategoryTableDisplayMenu(string selectCategory)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "SELECT ShortDescription, Category, Price FROM Item Where Category ='" + selectCategory + "'";

            myCommand = new OleDbCommand(queryString, myConnection);

            myDataAdapter = new OleDbDataAdapter(myCommand);

            itemDataSet = new DataSet("ItemsTable");

            myDataAdapter.Fill(itemDataSet, "ItemsTable");

            return itemDataSet.Tables["ItemsTable"];
        }

        //frmMenuDisplay if the user selects a row, it reference additional fields in the form controls (labels) like cost, long description and IMAGE!!!!
        public DataTable GetItemDetails(string shortDescription)
        {
            myConnection = new OleDbConnection(connectString);
            queryString = "SELECT ShortDescription, Price, Image, LongDescription, Cost FROM Item WHERE ShortDescription = '" + shortDescription + "'";

            myCommand = new OleDbCommand(queryString, myConnection);
             itemTable = new DataTable();

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                itemTable.Load(myDataReader);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                myDataReader.Close();
                myConnection.Close();
            }

            return itemTable;
        }

        //frmEmploeeCreate update the record
        //WORKING PROGRESS
        //I dont why this isnt working and it's driving me crazy
        //Asked the TA and she also drove herself crazy
        //reminder to fix this
        public void UpdateItem(string shortDescription, string longDescription, string category, string image, double price, double cost, int itemId)
        {
            myConnection = new OleDbConnection(connectString);

            queryString = "UPDATE Item SET ShortDescription = '" + shortDescription +
                          "', LongDescription = '" + longDescription +
                          "', Category = '" + category +
                          "', Image = '" + image +
                          "', Price = " + price +
                          ", Cost = " + cost +
                          " WHERE ID = " + itemId;

            myCommand = new OleDbCommand(queryString, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                myConnection.Close();
            }
        }




    }


}
