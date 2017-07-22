using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class New_dish : Form
    {
        Form1 parent_form;

        public New_dish(Form1 parent)
        {
            InitializeComponent();
            textBox_product.AutoCompleteCustomSource.AddRange(DataBase.GetProdList());
            textBox_product.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox_product.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dataGridView_products.Columns.Add("Name", "Продукт");
            dataGridView_products.Columns.Add("Weight", "Вес");
            parent_form = parent;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int total_weight = 0;
            double cal = 0;
            double prot = 0;
            double fat = 0;
            double carbo = 0;
            double[] row;
            dataGridView_products.Rows.Add(textBox_product.Text, textBox_weight.Text);
            for (int i = 0; i < dataGridView_products.RowCount; i++)
            {
                total_weight = total_weight + Convert.ToInt16(dataGridView_products[1, i].Value);
            }
            for (int i = 0; i < dataGridView_products.RowCount - 1; i++)
            {
                row = DataBase.GetProductStat(Convert.ToString(dataGridView_products[0, i].Value), Convert.ToInt16(Convert.ToDouble(dataGridView_products[1, i].Value) / Convert.ToDouble(total_weight) * 100));
                cal = cal + Convert.ToInt16(row[0]);
                prot = prot + Convert.ToInt16(row[1]);
                fat = fat + Convert.ToInt16(row[2]);
                carbo = carbo + Convert.ToInt16(row[3]);
            }
            label_cal.Text = Convert.ToString(cal);
            label_prot.Text = Convert.ToString(prot);
            label_fat.Text = Convert.ToString(fat);
            label_carbo.Text = Convert.ToString(carbo);
            textBox_product.Clear();
            textBox_weight.Clear();
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            DataBase.InsertProduct(string.Join(",", string.Join(null, "\'", textBox1.Text, "\'"), label_cal.Text, label_prot.Text, label_fat.Text, label_carbo.Text));

            parent_form.RefreshProdList();
            Close();
        }
    }
}
