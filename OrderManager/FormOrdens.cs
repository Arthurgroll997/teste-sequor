using OrderManagerBack.Models;
using OrderManagerFront;

namespace OrderManager
{
    public partial class FormOrdens : Form
    {
        private FormProducoes formProducoes = new FormProducoes();

        public FormOrdens()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            formProducoes.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
