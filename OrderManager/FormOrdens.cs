using OrderManagerBack.Dto;
using OrderManagerFront;

namespace OrderManager
{
    public partial class FormOrdens : Form
    {
        private FormProducoes formProducoes = new FormProducoes();
        private List<OrderDto> orders;
        private OrderDto? selectedOrder = null;
        private decimal cycleTimeTaken;

        public FormOrdens()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToggleOrderPanelElements(false);
            lblWaitingOrder.Show();

            orders = OrderFetcher.GetOrders();

            FillOrders(orders);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formProducoes.Show();
            Hide();
        }

        private void ToggleOrderPanelElements(bool show)
        {
            foreach (Control control in orderPanel.Controls)
                if (show)
                    control.Show();
                else
                    control.Hide();
        }

        private void FillOrders(List<OrderDto> orders)
        {
            orderCmbBox.Items.Clear();

            foreach (var order in orders)
            {
                orderCmbBox.Items.Add(order.Order);
            }

            orderCmbBox.Enabled = true;
            orderCmbBox.Text = "Selecionar";
        }

        private void orderCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            formBtnSend.Enabled = false;

            cycleTimeTaken = 0m;

            timerCycleTime.Stop();
            timerCycleTime.Start();

            selectedOrder = orders.Where(o => o.Order == (string)orderCmbBox.SelectedItem!).First()!;

            SetupOrderPanel();
            SetupFormPanel();

            ToggleOrderPanelElements(true);
            lblStatus.Text = "Aguardando envio do formulário...";
            lblWaitingOrder.Visible = false;
        }

        private void timerCycleTime_Tick(object sender, EventArgs e)
        {
            cycleTimeTaken += 0.1m;

            if (selectedOrder is not null && selectedOrder.CycleTime <= cycleTimeTaken)
                formBtnSend.Enabled = true;
        }

        private void SetupOrderPanel()
        {
            orderTxtOrder.Text = selectedOrder!.Order;
            orderTxtQuantity.Text = selectedOrder!.Quantity.ToString();
            orderTxtProductCode.Text = selectedOrder!.ProductCode;
            orderTxtProductDescription.Text = selectedOrder!.ProductDescription;
            orderTxtCycleTime.Text = selectedOrder!.CycleTime.ToString() + " seg.";

            orderlistMaterials.Items.Clear();
            orderlistMaterials.Columns.Clear();

            orderlistMaterials.Columns.AddRange([
                new ColumnHeader() { Text = "Code" },
                new ColumnHeader() { Text = "Description" },
            ]);

            // Resize das colunas, para preencherem completamente o ListView
            var totalWidth = orderlistMaterials.Width;
            var totalCol = orderlistMaterials.Columns.Count;

            foreach (ColumnHeader column in orderlistMaterials.Columns)
            {
                column.Width = totalWidth / totalCol;
            }

            int i = 0;

            foreach (var material in selectedOrder.Materials)
            {
                orderlistMaterials.Items.Add(new ListViewItem(material.MaterialCode));

                orderlistMaterials.Items[i].SubItems.Add(material.MaterialDescription);

                i++;
            }
        }

        private void SetupFormPanel()
        {

        }
    }
}
