namespace GyakZH2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products1 uc = new Products1();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products2 uc = new Products2();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Brands uc = new Brands();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductsByCategories uc = new ProductsByCategories();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}