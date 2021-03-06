﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{
    class DataBase
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        static SqlConnection connection = new SqlConnection(connectionString);
        static DateTime date = DateTime.Today;

        static public string[] GetProdList()
        {
            List<string> list = new List<string>();
            //connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM products WHERE active = 1", connection);
            SqlDataReader answer = command.ExecuteReader();
            while (answer.Read())
            {
                list.Add(answer.GetString(1));
            }
            answer.Close();
            //connection.Close();
            return list.ToArray();
        }

        static public void GetProdRef(string name)
        {
            SqlCommand command = new SqlCommand(string.Join(null, "SELECT id, caloricity, protein, fat, carbo FROM products WHERE name LIKE \'", name, "\'"), connection);
            SqlDataReader answer = command.ExecuteReader();
            while (answer.Read())
            {
                Product.id = Convert.ToString(answer.GetInt32(0));
                Product.cal = Convert.ToString(answer.GetDouble(1));
                Product.prot = Convert.ToString(answer.GetDouble(2)); ;
                Product.fat = Convert.ToString(answer.GetDouble(3)); ;
                Product.carbo = Convert.ToString(answer.GetDouble(4)); ;
            }
            answer.Close();
        }

        static public DataSet GetRation(string date_str)
        {
            //string date_str = date.ToString("yyyy-MM-dd");
            string query;
            query = string.Join(null, "select ration.id, products.name as 'Название', ration.value as 'Порция'," +
                "ration.value * products.caloricity / 100 as 'Калорийность', ration.value * products.protein / 100 as 'Белки'," +
                "ration.value * products.fat / 100 as 'Жиры', ration.value * products.carbo / 100 as 'Углеводы'" +
                "from products join ration on products.id = ration.product_id WHERE ration.date = '", date_str, "' and ration.active = 1");
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        static public void UpdateRation(string id, string value)
        {
            SqlCommand command = new SqlCommand(string.Join(null, "update ration set value = ", value, " where id = ", id), connection);
            command.ExecuteNonQuery();
        }

        static public void DeleteRowRation(string id)
        {
            SqlCommand command = new SqlCommand(string.Join(null, "update ration set active = 0 where id = ", id), connection);
            command.ExecuteNonQuery();
        }

        static public void GetDayStat(string date_str)
        {
            string query;
            query = string.Join(null, "select sum(products.caloricity * ration.value / 100), sum(products.protein * ration.value / 100)," +
                "sum(products.fat * ration.value / 100), sum(products.carbo * ration.value / 100) from ration join products on ration.product_id = products.id " +
                "where ration.date = '", date_str, "' and ration.active = 1 group by ration.date");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader answer = command.ExecuteReader();
            while (answer.Read())
            {
                Day.cal = Convert.ToString(answer.GetDouble(0));
                Day.prot = Convert.ToString(answer.GetDouble(1));
                Day.fat = Convert.ToString(answer.GetDouble(2));
                Day.carbo = Convert.ToString(answer.GetDouble(3));
            }
            answer.Close();
        }

        static public void InsertProduct(string query)
        {
            SqlCommand command = new SqlCommand(string.Join(null, "insert into products(name, caloricity, protein, fat, carbo) values ", "(", query, ")"), connection);
            int answer = command.ExecuteNonQuery();
        }

        static public void InsertRation(string query)
        {
            SqlCommand command = new SqlCommand(string.Join(null, "insert into ration(product_id, value, date, active) values ", "(", query, ")"), connection);
            int answer = command.ExecuteNonQuery();
        }

        static public void UpdateProduct(int id, double cal, double prot, double fat, double carbo)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("update_product", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@my_id", id);
            command.Parameters.AddWithValue("@new_cal", cal);
            command.Parameters.AddWithValue("@new_prot", prot);
            command.Parameters.AddWithValue("@new_fat", fat);
            command.Parameters.AddWithValue("@new_carbo", carbo);
            command.ExecuteNonQuery();
        }

        static public double[] GetProductStat(string name, int weight)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("get_prod_stat", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@weight", weight);
            command.Parameters.Add("@cal", SqlDbType.Float).Direction = ParameterDirection.Output;
            command.Parameters.Add("@prot", SqlDbType.Float).Direction = ParameterDirection.Output;
            command.Parameters.Add("@fat", SqlDbType.Float).Direction = ParameterDirection.Output;
            command.Parameters.Add("@carbo", SqlDbType.Float).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            double[] res = new double[4];
            res[0] = Convert.ToDouble(command.Parameters["@cal"].Value);
            res[1] = Convert.ToDouble(command.Parameters["@prot"].Value);
            res[2] = Convert.ToDouble(command.Parameters["@fat"].Value);
            res[3] = Convert.ToDouble(command.Parameters["@carbo"].Value);
            return res;
        }

        static public void DeleteProduct(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("disactivate_product", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@my_id", id);
            command.ExecuteNonQuery();
        }

        static public void Connect()
        {
            connection.Open();
        }
    }

    class Product
    {
        public static string id, cal, prot, fat, carbo;
    }

    class Day
    {
        public static string cal, prot, fat, carbo;
    }

    class Programm
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            DataBase.Connect();
            Application.Run(new Form1());
        }

    }
}
