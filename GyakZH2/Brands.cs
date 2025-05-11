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
    public partial class Brands : UserControl
    {
        BikestoreModels.SeBikestoreContext context = new();
        public Brands()
        {
            InitializeComponent();
        }

        private void Brands_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Brands.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BikestoreModels.Brand brand = new();

            brand.BrandName = textBox1.Text;

            context.Brands.Add(brand);
            context.SaveChanges();
            dataGridView1.DataSource = context.Brands.ToList(); //újraolvasás
        }
    }
}
