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
    public partial class Form2 : Form
    {
        Form1 parent_form;

        public Form2(Form1 parent)
        {
            //this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            parent_form = parent;
        }

        private void new_prod_create_Click(object sender, EventArgs e)
        {
            if (!DataBase.GetProdList().Contains(new_prod_name.Text))
            {
                DataBase.Insert(string.Join(",", string.Join(null, "\'", new_prod_name.Text, "\'"), new_prod_cal.Text, new_prod_prot.Text, new_prod_fat.Text, new_prod_hyd.Text));
                parent_form.RefreshProdList();
                Close();
            }
            else
                MessageBox.Show("Такой продукт уже есть");
        }
    }
}
