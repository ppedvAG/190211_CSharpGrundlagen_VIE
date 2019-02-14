using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLAbfrage_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source=(localDB)\\MSSQLLocalDB");
            con.Open();

            SqlCommand meinCommand = new SqlCommand($"SELECT * FROM Northwind.Dbo.Products",con);

            SqlDataReader reader = meinCommand.ExecuteReader();

            while(reader.Read())
            {
                int id = (int)reader["ProductID"];
                Console.WriteLine(id);
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
