using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace AddressBook_ADO
{
    class DatabaseManager
    {
        public void CreateDatabase()
        {
            SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDb)\localdb;Integrated Security=True");
            String str = "CREATE DATABASE AddressBook ";
            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("Database is Created Successfully");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
