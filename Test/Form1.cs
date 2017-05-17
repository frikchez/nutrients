using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            RefreshProdList();
            CreateRationTable(DataBase.GetRation(DateTime.Today.ToString("yyyy-MM-dd")));
        }

        public void RefreshProdList()
        {
            prod_name.AutoCompleteCustomSource.AddRange(DataBase.GetProdList());
            prod_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            prod_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void CreateRationTable(DataSet data)
        {
            dataGridView1.DataSource = data.Tables[0];
            DataBase.GetDayStat(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            prod_name.Text = prod_value.Text = cal_ref.Text = prot_ref.Text = fat_ref.Text = hyd_ref.Text = "";
            cal_day.Text = Day.cal;
            prot_day.Text = Day.prot;
            fat_day.Text = Day.fat;
            carbo_day.Text = Day.carbo;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].ReadOnly = true;
            for (int i = 3; i < 7; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // добавить продукт в рацион
        private void prod_name_KeyDown(object sender, KeyEventArgs e)
        {
            DataBase.GetProdRef(prod_name.Text);
            if (e.KeyCode == Keys.Enter)
            {
                cal_ref.Text = Product.cal;
                prot_ref.Text = Product.prot;
                fat_ref.Text = Product.fat;
                hyd_ref.Text = Product.carbo;
            }
        }

        // внести новый продукт
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FormNewProduct = new Form2(this);
            FormNewProduct.Show();
        }

        // отобразить рацион за день
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CreateRationTable(DataBase.GetRation(dateTimePicker1.Value.ToString("yyyy-MM-dd")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase.InsertRation(string.Join(",", Product.id, prod_value.Text, string.Join(null, "\'", DateTime.Today.ToString("yyyy-MM-dd"), "\'"), "1"));
            CreateRationTable(DataBase.GetRation(dateTimePicker1.Value.ToString("yyyy-MM-dd")));
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            DataBase.UpdateRation(id, value);
        }
    }
}
