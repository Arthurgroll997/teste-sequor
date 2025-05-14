namespace OrderManagerFront
{
    public partial class FormProducoes : Form
    {
        public FormProducoes()
        {
            InitializeComponent();
            lstProductions.Scrollable = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1?.Show();
            Hide();
        }

        private void formClosing(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1?.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblWaitingSearch.Hide();
            lstProductions.Items.Clear();
            lstProductions.Columns.Clear();

            var producoes = OrderFetcher.GetProductionForEmail(txtEmailProduction.Text);

            lstProductions.Columns.AddRange([
                new ColumnHeader() { Text = "Order" },
                new ColumnHeader() { Text = "Date" },
                new ColumnHeader() { Text = "Quantity" },
                new ColumnHeader() { Text = "Material Code" },
                new ColumnHeader() { Text = "Cycle Time" },
            ]);

            // Resize das colunas, para preencherem completamente o ListView
            var totalWidth = lstProductions.Width;
            var totalCol = lstProductions.Columns.Count;

            foreach(ColumnHeader column in lstProductions.Columns)
            {
                column.Width = totalWidth / totalCol;
            }

            int i = 0;

            foreach(var prod in producoes)
            {
                lstProductions.Items.Add(new ListViewItem(prod.Order));

                lstProductions.Items[i].SubItems.Add(prod.Date);
                lstProductions.Items[i].SubItems.Add(prod.Quantity.ToString());
                lstProductions.Items[i].SubItems.Add(prod.MaterialCode);
                lstProductions.Items[i].SubItems.Add(prod.CycleTime.ToString() + " seg");

                i++;
            }

            txtEmailProduction.Text = "";
        }
    }
}
