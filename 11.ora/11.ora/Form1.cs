namespace _11.ora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 uc = new();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl2 uc = new();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl2 uc = new();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
