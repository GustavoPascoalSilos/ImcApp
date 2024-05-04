namespace ImcApp
{
    partial class frmCalculaImc
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
            panel1 = new Panel();
            lblAltura = new Label();
            lblPeso = new Label();
            numAltura = new NumericUpDown();
            numPeso = new NumericUpDown();
            btnCalcular = new Button();
            label1 = new Label();
            seta = new PictureBox();
            lblResultado = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAltura);
            panel1.Controls.Add(lblPeso);
            panel1.Controls.Add(numAltura);
            panel1.Controls.Add(numPeso);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 454);
            panel1.TabIndex = 0;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(62, 205);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(115, 20);
            lblAltura.TabIndex = 5;
            lblAltura.Text = "Qual sua altura?";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(62, 106);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(109, 20);
            lblPeso.TabIndex = 4;
            lblPeso.Text = "Qual seu peso?";
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Location = new Point(62, 228);
            numAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(150, 27);
            numAltura.TabIndex = 3;
            numAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Location = new Point(62, 129);
            numPeso.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(150, 27);
            numPeso.TabIndex = 2;
            numPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightGreen;
            btnCalcular.Location = new Point(90, 323);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 51);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Calcular IMC";
            // 
            // seta
            // 
            seta.BackColor = Color.Transparent;
            seta.Image = Properties.Resources.seta;
            seta.Location = new Point(314, 118);
            seta.Name = "seta";
            seta.Size = new Size(55, 62);
            seta.SizeMode = PictureBoxSizeMode.StretchImage;
            seta.TabIndex = 4;
            seta.TabStop = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Red;
            lblResultado.Location = new Point(323, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(89, 98);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.obesidade__1_;
            pictureBox1.Location = new Point(314, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmCalculaImc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 456);
            Controls.Add(seta);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultado);
            Controls.Add(panel1);
            Name = "frmCalculaImc";
            Text = "Calcular IMC";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)seta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblAltura;
        private Label lblPeso;
        private NumericUpDown numAltura;
        private NumericUpDown numPeso;
        private Button btnCalcular;
        private Label lblResultado;
        private PictureBox pictureBox1;
        private PictureBox seta;
    }
}