using System;
using System.Data.SqlClient;

namespace adonetdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            /*Step 0. Create your Db on Azure Portal and remember the password and connection string*/

            /* Step1. Download Microsoft.Data.SqlClient */

            /* Step 2. Create a connection string variable.
            Normally, this variable is hidden and is not pushed to Github.
            That is reckless.*/
            //Console.WriteLine("Please tell me your Db password!");
            // string pswd = Console.ReadLine();
            string connectionString = $"Server=tcp:adopractice-server-moore.database.windows.net,1433;Initial Catalog=adonetpractice_moore;Persist Security Info=False;User ID=adonetpractice;Password=Thisis1funnyhorse!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


            //QUERY 1
            Console.WriteLine("\n\tEntering the 1st Query\n");

            /*Create your query*/
            string myQuery1 = "SELECT city, AddressID, PostalCode FROM SalesLT.Address WHERE AddressID >100 ORDER BY PostalCode, AddressID;";
            //this using block creates teh SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection query1 = new SqlConnection(connectionString))
            {
                //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery1, query1/*0xf35ba*/);

                command.Connection.Open();//open the connection to the Db

                SqlDataReader results = command.ExecuteReader();//actually conduct the query.

                while (results.Read())
                {
                    Console.WriteLine($"The address is => {results[0]} {results[1]}, {results[2]}");
                }
                query1.Close();
            }


            //QUERY 2
            /*Create your query*/
            Console.WriteLine("\n\tEntering the 2nd Query\n");

            Console.WriteLine("What is the minimum AddressID you want?");
            string maxAddyId = Console.ReadLine();// this is dangerous bc of SQL Injection => Select * FROM Address;

            string myQuery2 = $"SELECT AddressID, City, PostalCode FROM SalesLT.Address WHERE AddressID > @maxId ORDER BY PostalCode, AddressID;";
            //this using block creates the SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery2, connection);
                command.Parameters.AddWithValue("@maxId", maxAddyId);
                connection.Open();//open the connection to the Db

                try
                {
                    SqlDataReader results = command.ExecuteReader();//actually conduct the query.
                    while (results.Read())//read this result set line by line. Each line is returned as an (untitled) array.
                    {
                        Console.WriteLine($"The address is => {results[0]} {results[1]}, {results[2]}");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"There was an exception {ex.Message}. ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"There was an exception {ex.Message}. ");
                }

                connection.Close();
            }

            // QUERY 3
            /*Create your query*/
            Console.WriteLine("\n\tEntering the 3rd Query to INSERT\n");

            string myQuery3 = $"INSERT INTO SalesLT.Address (AddressLine1, City, StateProvince, CountryRegion, PostalCode) VALUES ('111 Main St', 'Arlington', 'TX','USA', '76011');";
            //this using block creates the SqlConnection.
            // the SqlConnection is the object that communicates with the Db.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
                SqlCommand command = new SqlCommand(myQuery3, connection);
                //command.Parameters.AddWithValue("@maxId", myQuery3);

                command.Connection.Open();//open the connection to the Db

                int results = command.ExecuteNonQuery();//actually conduct the query.

                if (results > 0)
                {
                    Console.WriteLine("The transaction was (probably) successful!");
                }
                connection.Close();
            }
        }
    }
}
