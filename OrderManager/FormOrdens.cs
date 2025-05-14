using System.Buffers.Text;
using System.Windows.Forms;
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
            formDateProduction.Format = DateTimePickerFormat.Custom;
            formDateProduction.CustomFormat = "yyyy-MM-dd HH:mm:ss";
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
            lblStatus.ForeColor = Color.Black;
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

            // Puxando a imagem
            byte[] imageBytes = Convert.FromBase64String(selectedOrder.Image);

            using (var ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                orderImgProduct.Image = image;
            }
        }

        private void SetupFormPanel()
        {
            formTxtEmail.Enabled = true;
            formComboMaterialCode.Items.Clear();
            formDateProduction.Enabled = true;
            formNumericQuantity.Enabled = true;

            foreach (var material in selectedOrder!.Materials)
            {
                formComboMaterialCode.Items.Add(material.MaterialCode);
            }

            formComboMaterialCode.Enabled = true;
            formComboMaterialCode.SelectedIndex = 0;
        }

        private void ResetForm()
        {
            formTxtEmail.Text = "";
            formComboMaterialCode.SelectedIndex = 0;
            formNumericQuantity.Value = 1;
            cycleTimeTaken = 0m;
            formBtnSend.Enabled = false;
            formDateProduction.Value = DateTime.Now;
        }

        private void formBtnSend_Click(object sender, EventArgs e)
        {
            lblStatus.ForeColor = Color.Black;

            SetProductionInputDto input = new SetProductionInputDto()
            {
                Email = formTxtEmail.Text,
                Order = selectedOrder!.Order,
                ProductionDate = formDateProduction.Value.ToString("yyyy-MM-dd"),
                ProductionTime = formDateProduction.Value.ToString("HH:mm:ss"),
                Quantity = formNumericQuantity.Value,
                MaterialCode = (string)formComboMaterialCode.SelectedItem!,
                CycleTime = cycleTimeTaken,
            };

            var result = OrderFetcher.SetProduction(input);

            if (result.Status == 200)
            {
                lblStatus.ForeColor = Color.ForestGreen;
                ResetForm();
            }
            else
            {
                lblStatus.ForeColor = Color.LightSalmon;
            }

            lblStatus.Text = result.Description;
        }
    }
}
