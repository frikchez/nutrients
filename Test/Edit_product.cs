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
    public partial class Edit_product : Form
    {
        Form1 parent_form;

        public Edit_product(Form1 parent)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            parent_form = parent;
            name.AutoCompleteCustomSource.AddRange(DataBase.GetProdList());
            name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void name_KeyDown(object sender, KeyEventArgs e)
        {
            DataBase.GetProdRef(name.Text);
            if (e.KeyCode == Keys.Enter)
            {
                cal.Text = Product.cal;
                prot.Text = Product.prot;
                fat.Text = Product.fat;
                hyd.Text = Product.carbo;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            DataBase.UpdateProduct(Convert.ToInt32(Product.id), Convert.ToDouble(cal.Text), Convert.ToDouble(prot.Text), Convert.ToDouble(fat.Text), Convert.ToDouble(hyd.Text));
            parent_form.RefreshProdList();
            Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DataBase.DeleteProduct(Convert.ToInt32(Product.id));
            parent_form.RefreshProdList();
            Close();
        }
    }
}
