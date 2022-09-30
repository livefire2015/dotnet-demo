using System;
using System.Data;
using Microsoft.Data.SqlClient;

// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hellow World");

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "host.docker.internal";
            builder.UserID = "sa";
            builder.Password = "mssql1Ipw";
            builder.InitialCatalog = "master";
            builder.IntegratedSecurity = false;
            builder.TrustServerCertificate = true;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection Status is {0}", connection.State);
                    Console.WriteLine("Server Version is {0}", connection.ServerVersion);
                    connection.Close();
                    Console.Write("Press Enter to Continue:");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}