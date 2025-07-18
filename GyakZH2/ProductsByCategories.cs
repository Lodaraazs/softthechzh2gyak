﻿using System;
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
    public partial class ProductsByCategories : UserControl
    {
        BikestoreModels.SeBikestoreContext context = new();
        public ProductsByCategories()
        {
            InitializeComponent();
        }

        private void ProductsByCategories_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = context.Categories.ToList();
        }

        private void categoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current == null) return;
            BikestoreModels.Category cat = categoryBindingSource.Current as BikestoreModels.Category;

            var xxx = from x in context.Products
                      where x.CategoryFk == cat.CategorySk
                      select x;

            dataGridView1.DataSource = xxx.ToList();
        }
    }
}
