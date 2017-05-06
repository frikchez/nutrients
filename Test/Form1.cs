using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            CreateRationTable(DataBase.GetRation());
            //DataBase.GetRation();
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void prod_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void prod_name_KeyDown(object sender, KeyEventArgs e)
        {
            int[] list = DataBase.GetProdRef(prod_name.Text);
            if (e.KeyCode == Keys.Enter)
            {
                cal_ref.Text = Convert.ToString(list[0]);
                prot_ref.Text = Convert.ToString(list[1]);
                fat_ref.Text = Convert.ToString(list[2]);
                hyd_ref.Text = Convert.ToString(list[3]);
            }
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FormNewProduct = new Form2(this);
            FormNewProduct.Show();
        }
    }
}
