namespace OrderManagerFront
{
    partial class FormProducoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducoes));
            pictureBox1 = new PictureBox();
            btnGoBack = new Button();
            panel1 = new Panel();
            btnGetProduction = new Button();
            label1 = new Label();
            txtEmailProduction = new TextBox();
            lstProductions = new ListView();
            lblWaitingSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(639, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoBack.Location = new Point(1153, 28);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(121, 40);
            btnGoBack.TabIndex = 3;
            btnGoBack.Text = "Voltar";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGetProduction);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGoBack);
            panel1.Controls.Add(txtEmailProduction);
            panel1.Controls.Add(lblWaitingSearch);
            panel1.Controls.Add(lstProductions);
            panel1.Location = new Point(12, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 588);
            panel1.TabIndex = 4;
            // 
            // btnGetProduction
            // 
            btnGetProduction.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetProduction.Location = new Point(400, 26);
            btnGetProduction.Name = "btnGetProduction";
            btnGetProduction.Size = new Size(196, 40);
            btnGetProduction.TabIndex = 8;
            btnGetProduction.Text = "Obter Dados";
            btnGetProduction.UseVisualStyleBackColor = true;
            btnGetProduction.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(80, 27);
            label1.TabIndex = 7;
            label1.Text = "Email:";
            // 
            // txtEmailProduction
            // 
            txtEmailProduction.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailProduction.Location = new Point(91, 32);
            txtEmailProduction.Name = "txtEmailProduction";
            txtEmailProduction.Size = new Size(288, 26);
            txtEmailProduction.TabIndex = 6;
            // 
            // lstProductions
            // 
            lstProductions.BackColor = SystemColors.ControlLight;
            lstProductions.GridLines = true;
            lstProductions.Location = new Point(3, 86);
            lstProductions.Name = "lstProductions";
            lstProductions.Size = new Size(1271, 502);
            lstProductions.TabIndex = 5;
            lstProductions.UseCompatibleStateImageBehavior = false;
            lstProductions.View = View.Details;
            // 
            // lblWaitingSearch
            // 
            lblWaitingSearch.BackColor = SystemColors.ControlLight;
            lblWaitingSearch.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWaitingSearch.Location = new Point(3, 86);
            lblWaitingSearch.Name = "lblWaitingSearch";
            lblWaitingSearch.Size = new Size(1271, 502);
            lblWaitingSearch.TabIndex = 9;
            lblWaitingSearch.Text = "Aguardando pesquisa...";
            lblWaitingSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormProducoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 759);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormProducoes";
            Text = "Gerenciador de Ordens - Visualização de Produção";
            FormClosing += formClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnGoBack;
        private Panel panel1;
        private ListView lstProductions;
        private Button btnGetProduction;
        private Label label1;
        private TextBox txtEmailProduction;
        private Label lblWaitingSearch;
    }
}