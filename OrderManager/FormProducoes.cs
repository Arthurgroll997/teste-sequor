using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManager;

namespace OrderManagerFront
{
    public partial class FormProducoes : Form
    {
        public FormProducoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1?.Show();
            Hide();
        }
    }
}
