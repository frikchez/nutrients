using System;
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
            SqlCommand command = new SqlCommand("SELECT * FROM products", connection);
            SqlDataReader answer = command.ExecuteReader();
            while (answer.Read())
            {
                list.Add(answer.GetString(1));
            }
            answer.Close();
            //connection.Close();
            return list.ToArray();
        }

        static public int[] GetProdRef(string name)
        {
            int[] list = new int[4];
            //connection.Open();
            SqlCommand command = new SqlCommand(string.Join(null, "SELECT * FROM products WHERE name LIKE \'", name, "\'"), connection);
            SqlDataReader answer = command.ExecuteReader();
            while (answer.Read())
            {
                for (int i = 0; i < 4; i++)
                    list[i] = answer.GetInt32(i + 2);
            }
            answer.Close();
            //connection.Close();
            return list;
        }

        static public DataSet GetRation()
        {
            string date_str = date.ToString("yyyy-MM-dd");
            string query;
            MessageBox.Show(date_str);
            query = string.Join(null, "select products.name, ration.value * products.caloricity / 100 as cal "+
                "from products join ration on products.id = ration.product_id WHERE ration.date = '", date_str, "'");
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        static public void Insert(string query)
        {
            SqlCommand command = new SqlCommand(string.Join(null, "insert into products(name, caloricity, protein, fat, carbo) values ", "(", query, ")"), connection);
            int answer = command.ExecuteNonQuery();
        }

        static public void Connect()
        {
            connection.Open();
        }
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
