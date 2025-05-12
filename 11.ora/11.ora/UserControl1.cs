using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.PerformanceData;

namespace _11.ora
{
    public partial class UserControl1 : UserControl
    {
        BindingList<CountryData> lista = new();
        public UserControl1()
        {
            InitializeComponent();
            dataGridView1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);

                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(",");

                    CountryData countryData = new()
                    {
                        Name = line[0],
                        Population = long.Parse(line[1]),
                        AreaInSquareKm = int.Parse(line[2])
                    };

                    lista.Add(countryData);
                }
                sr.Close();
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var largestArea = (from x in lista
                              select x.AreaInSquareKm).Max();

            label1.Text = largestArea.ToString();

            var averagePopulation = (from x in lista
                                     select x.Population).Average();

            label2.Text = averagePopulation.ToString();

            var largestCountry = (from x in lista
                                  where x.AreaInSquareKm == largestArea
                                  select x).FirstOrDefault();

            label3.Text = largestCountry.Name;

            var countriesAboveAveragePopulation = from x in lista
                                                  where x.Population >= averagePopulation
                                                  orderby x.Name
                                                  select x;

            dataGridView2.DataSource = countriesAboveAveragePopulation.ToList();
        }
    }
}
