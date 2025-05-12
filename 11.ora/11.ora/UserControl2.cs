using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.ora
{
    public partial class UserControl2 : UserControl
    {
        BikestoreModels.SeBikestoreContext context = new();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);

                foreach (var item in context.Brands.ToList())
                {
                    sw.WriteLine($"{item.BrandSk};{item.BrandName}");
                }
                
                sw.Close();
            }
        }
    }
}
