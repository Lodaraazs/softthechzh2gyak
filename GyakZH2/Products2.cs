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
    public partial class Products2 : UserControl
    {
        BikestoreModels.SeBikestoreContext context = new();
        public Products2()
        {
            InitializeComponent();
        }

        private void Products2_Load(object sender, EventArgs e)
        {
            var xxx = from x in context.Products
                      select new
                      {
                          ProductName__ = x.ProductName,
                          Category__ = x.CategoryFkNavigation.CategoryName,
                          Brand__ = x.Brand.BrandName, // nem mindig van navigation
                          Price__ = x.ListPrice
                      };
            dataGridView1.DataSource = xxx.ToList();
        }
    }
}
