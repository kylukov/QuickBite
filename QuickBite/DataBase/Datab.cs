using System;
using Data;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace QuickBite.DataBase
{
    public class Datab
    {
        public static void find_receipt(string stri)
        {
            Database database = new Database();
            string spisok = stri;
            MySqlConnection connection = new MySqlConnection("Data Source=DESKTOP;Initial Catalog=ProductsDB;Integrated Security=true");
            connection.Open();
            DataTable table = new DataTable();

            string querystring = $"select name_of_receipt, list_products_for_receipt from products where list_products_for_receipt = '{spisok}'";
            //SqlCommand command = new SqlCommand(querystring, database.getConnection());

            MySqlCommand command = new MySqlCommand(querystring, connection);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Привет");
            while (reader.Read())
            {
                string output = "Название рецепта: " + reader.GetValue(0) + "\tИнгредиенты:" + reader.GetValue(1);
                Console.WriteLine(output);
            }
            Console.ReadKey();

        }
    }
}

