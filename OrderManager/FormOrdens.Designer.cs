namespace OrderManager
{
    partial class FormOrdens
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdens));
            panel1 = new Panel();
            orderCmbBox = new ComboBox();
            lblStatus = new Label();
            formPanel = new Panel();
            formBtnSend = new Button();
            formDateProduction = new DateTimePicker();
            formComboMaterialCode = new ComboBox();
            label14 = new Label();
            formNumericQuantity = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            formTxtEmail = new TextBox();
            label9 = new Label();
            orderPanel = new Panel();
            label11 = new Label();
            orderlistMaterials = new ListView();
            label8 = new Label();
            orderTxtOrder = new TextBox();
            orderTxtProductDescription = new RichTextBox();
            label7 = new Label();
            orderTxtQuantity = new TextBox();
            label6 = new Label();
            orderTxtCycleTime = new TextBox();
            label5 = new Label();
            orderTxtProductCode = new TextBox();
            label4 = new Label();
            label3 = new Label();
            orderImgProduct = new PictureBox();
            lblWaitingOrder = new Label();
            label1 = new Label();
            btnSeeProduction = new Button();
            pictureBox1 = new PictureBox();
            timerCycleTime = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)formNumericQuantity).BeginInit();
            orderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderImgProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(orderCmbBox);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(formPanel);
            panel1.Controls.Add(orderPanel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSeeProduction);
            panel1.Location = new Point(12, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(1296, 757);
            panel1.TabIndex = 0;
            // 
            // orderCmbBox
            // 
            orderCmbBox.Enabled = false;
            orderCmbBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderCmbBox.FormattingEnabled = true;
            orderCmbBox.Location = new Point(208, 19);
            orderCmbBox.Name = "orderCmbBox";
            orderCmbBox.Size = new Size(179, 28);
            orderCmbBox.TabIndex = 5;
            orderCmbBox.Text = "Carregando...";
            orderCmbBox.SelectedIndexChanged += orderCmbBox_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(15, 697);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1275, 52);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Selecione uma ordem";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formPanel
            // 
            formPanel.BackColor = SystemColors.ControlLight;
            formPanel.Controls.Add(formBtnSend);
            formPanel.Controls.Add(formDateProduction);
            formPanel.Controls.Add(formComboMaterialCode);
            formPanel.Controls.Add(label14);
            formPanel.Controls.Add(formNumericQuantity);
            formPanel.Controls.Add(label13);
            formPanel.Controls.Add(label12);
            formPanel.Controls.Add(label10);
            formPanel.Controls.Add(formTxtEmail);
            formPanel.Controls.Add(label9);
            formPanel.Location = new Point(778, 66);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(512, 624);
            formPanel.TabIndex = 3;
            // 
            // formBtnSend
            // 
            formBtnSend.Enabled = false;
            formBtnSend.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formBtnSend.Location = new Point(16, 548);
            formBtnSend.Name = "formBtnSend";
            formBtnSend.Size = new Size(481, 57);
            formBtnSend.TabIndex = 27;
            formBtnSend.Text = "Enviar";
            formBtnSend.UseVisualStyleBackColor = true;
            // 
            // formDateProduction
            // 
            formDateProduction.Enabled = false;
            formDateProduction.Location = new Point(111, 273);
            formDateProduction.Name = "formDateProduction";
            formDateProduction.Size = new Size(301, 27);
            formDateProduction.TabIndex = 20;
            // 
            // formComboMaterialCode
            // 
            formComboMaterialCode.Enabled = false;
            formComboMaterialCode.FormattingEnabled = true;
            formComboMaterialCode.Location = new Point(157, 142);
            formComboMaterialCode.Name = "formComboMaterialCode";
            formComboMaterialCode.Size = new Size(301, 28);
            formComboMaterialCode.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F);
            label14.Location = new Point(16, 145);
            label14.Name = "label14";
            label14.Size = new Size(94, 23);
            label14.TabIndex = 25;
            label14.Text = "Material:";
            // 
            // formNumericQuantity
            // 
            formNumericQuantity.Enabled = false;
            formNumericQuantity.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formNumericQuantity.Location = new Point(157, 189);
            formNumericQuantity.Name = "formNumericQuantity";
            formNumericQuantity.Size = new Size(301, 26);
            formNumericQuantity.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(7, 28);
            label13.Name = "label13";
            label13.Size = new Size(335, 37);
            label13.TabIndex = 23;
            label13.Text = "Envio para produção:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F);
            label12.Location = new Point(15, 192);
            label12.Name = "label12";
            label12.Size = new Size(135, 23);
            label12.TabIndex = 22;
            label12.Text = "Quantidade:";
            // 
            // label10
            // 
            label10.Font = new Font("Century Gothic", 12F);
            label10.Location = new Point(3, 236);
            label10.Name = "label10";
            label10.Size = new Size(506, 29);
            label10.TabIndex = 21;
            label10.Text = "Data de Apontamento:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formTxtEmail
            // 
            formTxtEmail.Enabled = false;
            formTxtEmail.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formTxtEmail.Location = new Point(157, 98);
            formTxtEmail.Name = "formTxtEmail";
            formTxtEmail.Size = new Size(301, 26);
            formTxtEmail.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.Location = new Point(17, 99);
            label9.Name = "label9";
            label9.Size = new Size(67, 23);
            label9.TabIndex = 18;
            label9.Text = "Email:";
            // 
            // orderPanel
            // 
            orderPanel.BackColor = SystemColors.ControlLight;
            orderPanel.Controls.Add(label11);
            orderPanel.Controls.Add(orderlistMaterials);
            orderPanel.Controls.Add(label8);
            orderPanel.Controls.Add(orderTxtOrder);
            orderPanel.Controls.Add(orderTxtProductDescription);
            orderPanel.Controls.Add(label7);
            orderPanel.Controls.Add(orderTxtQuantity);
            orderPanel.Controls.Add(label6);
            orderPanel.Controls.Add(orderTxtCycleTime);
            orderPanel.Controls.Add(label5);
            orderPanel.Controls.Add(orderTxtProductCode);
            orderPanel.Controls.Add(label4);
            orderPanel.Controls.Add(label3);
            orderPanel.Controls.Add(orderImgProduct);
            orderPanel.Controls.Add(lblWaitingOrder);
            orderPanel.Location = new Point(15, 66);
            orderPanel.Name = "orderPanel";
            orderPanel.Size = new Size(757, 624);
            orderPanel.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F);
            label11.Location = new Point(22, 302);
            label11.Name = "label11";
            label11.Size = new Size(98, 23);
            label11.TabIndex = 18;
            label11.Text = "Imagem:";
            // 
            // orderlistMaterials
            // 
            orderlistMaterials.Location = new Point(19, 161);
            orderlistMaterials.Name = "orderlistMaterials";
            orderlistMaterials.Size = new Size(718, 133);
            orderlistMaterials.TabIndex = 17;
            orderlistMaterials.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.Location = new Point(19, 127);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 16;
            label8.Text = "Materiais:";
            // 
            // orderTxtOrder
            // 
            orderTxtOrder.Font = new Font("Century Gothic", 9F);
            orderTxtOrder.Location = new Point(178, 35);
            orderTxtOrder.Name = "orderTxtOrder";
            orderTxtOrder.ReadOnly = true;
            orderTxtOrder.Size = new Size(160, 26);
            orderTxtOrder.TabIndex = 15;
            // 
            // orderTxtProductDescription
            // 
            orderTxtProductDescription.Location = new Point(386, 339);
            orderTxtProductDescription.Name = "orderTxtProductDescription";
            orderTxtProductDescription.ReadOnly = true;
            orderTxtProductDescription.Size = new Size(351, 266);
            orderTxtProductDescription.TabIndex = 14;
            orderTxtProductDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.Location = new Point(386, 300);
            label7.Name = "label7";
            label7.Size = new Size(229, 23);
            label7.TabIndex = 13;
            label7.Text = "Descrição do Produto:";
            // 
            // orderTxtQuantity
            // 
            orderTxtQuantity.Font = new Font("Century Gothic", 9F);
            orderTxtQuantity.Location = new Point(178, 75);
            orderTxtQuantity.Name = "orderTxtQuantity";
            orderTxtQuantity.ReadOnly = true;
            orderTxtQuantity.Size = new Size(160, 26);
            orderTxtQuantity.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(19, 74);
            label6.Name = "label6";
            label6.Size = new Size(135, 23);
            label6.TabIndex = 11;
            label6.Text = "Quantidade:";
            // 
            // orderTxtCycleTime
            // 
            orderTxtCycleTime.Font = new Font("Century Gothic", 9F);
            orderTxtCycleTime.Location = new Point(577, 77);
            orderTxtCycleTime.Name = "orderTxtCycleTime";
            orderTxtCycleTime.ReadOnly = true;
            orderTxtCycleTime.Size = new Size(160, 26);
            orderTxtCycleTime.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.Location = new Point(371, 76);
            label5.Name = "label5";
            label5.Size = new Size(171, 23);
            label5.TabIndex = 9;
            label5.Text = "Tempo de Ciclo:";
            // 
            // orderTxtProductCode
            // 
            orderTxtProductCode.Font = new Font("Century Gothic", 9F);
            orderTxtProductCode.Location = new Point(577, 33);
            orderTxtProductCode.Name = "orderTxtProductCode";
            orderTxtProductCode.ReadOnly = true;
            orderTxtProductCode.Size = new Size(160, 26);
            orderTxtProductCode.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(371, 36);
            label4.Name = "label4";
            label4.Size = new Size(179, 23);
            label4.TabIndex = 7;
            label4.Text = "Cód. do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(22, 36);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 6;
            label3.Text = "Ordem:";
            // 
            // orderImgProduct
            // 
            orderImgProduct.Image = (Image)resources.GetObject("orderImgProduct.Image");
            orderImgProduct.Location = new Point(19, 339);
            orderImgProduct.Name = "orderImgProduct";
            orderImgProduct.Size = new Size(263, 266);
            orderImgProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            orderImgProduct.TabIndex = 5;
            orderImgProduct.TabStop = false;
            // 
            // lblWaitingOrder
            // 
            lblWaitingOrder.Font = new Font("Century Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWaitingOrder.Location = new Point(3, 0);
            lblWaitingOrder.Name = "lblWaitingOrder";
            lblWaitingOrder.Size = new Size(751, 624);
            lblWaitingOrder.TabIndex = 19;
            lblWaitingOrder.Text = "Aguardando ordem...";
            lblWaitingOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 1;
            label1.Text = "Selecionar Ordem";
            // 
            // btnSeeProduction
            // 
            btnSeeProduction.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeeProduction.Location = new Point(1091, 20);
            btnSeeProduction.Name = "btnSeeProduction";
            btnSeeProduction.Size = new Size(199, 29);
            btnSeeProduction.TabIndex = 0;
            btnSeeProduction.Text = "Ver Apontamentos";
            btnSeeProduction.UseVisualStyleBackColor = true;
            btnSeeProduction.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timerCycleTime
            // 
            timerCycleTime.Tick += timerCycleTime_Tick;
            // 
            // FormOrdens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 941);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormOrdens";
            Text = "Gerenciador de Ordens - Visualização de Ordens";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            formPanel.ResumeLayout(false);
            formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)formNumericQuantity).EndInit();
            orderPanel.ResumeLayout(false);
            orderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderImgProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnSeeProduction;
        private Panel orderPanel;
        private Label label1;
        private ComboBox orderCmbBox;
        private Label lblStatus;
        private Panel formPanel;
        private PictureBox orderImgProduct;
        private TextBox orderTxtProductCode;
        private Label label4;
        private Label label3;
        private TextBox orderTxtQuantity;
        private Label label6;
        private TextBox orderTxtCycleTime;
        private Label label5;
        private RichTextBox orderTxtProductDescription;
        private Label label7;
        private TextBox orderTxtOrder;
        private Label label8;
        private ListView orderlistMaterials;
        private System.Windows.Forms.Timer timerCycleTime;
        private Label label10;
        private DateTimePicker formDateProduction;
        private TextBox formTxtEmail;
        private Label label9;
        private Label label11;
        private ComboBox formComboMaterialCode;
        private Label label14;
        private NumericUpDown formNumericQuantity;
        private Label label13;
        private Label label12;
        private Button formBtnSend;
        private Label lblWaitingOrder;
    }
}
