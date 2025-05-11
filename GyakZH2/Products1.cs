using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GyakZH2
{
    public partial class Products1 : UserControl
    {
        BikestoreModels.SeBikestoreContext context = new();

        public Products1()
        {
            InitializeComponent();
        }

        private void Products1_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = context.Products.ToList();
            categoryBindingSource.DataSource = context.Categories.ToList();
            brandBindingSource.DataSource = context.Brands.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var xxx = from x in context.Products
                      where x.ProductName.Contains(textBox1.Text)
                      select x;

            productBindingSource.DataSource = xxx.ToList();
        }
    }
}
