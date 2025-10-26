namespace pryBazanSPP2
{
    partial class frmBoleteria
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
            lblTitulo = new Label();
            gbInformacion = new GroupBox();
            NupDias = new NumericUpDown();
            NupDistancia = new NumericUpDown();
            lblDias = new Label();
            lblDistancia = new Label();
            gpRespuestras = new GroupBox();
            lstResultado = new ListBox();
            lblPrecio = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            gbInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NupDias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NupDistancia).BeginInit();
            gpRespuestras.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(337, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(425, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ORGANIZACION FERRO";
            // 
            // gbInformacion
            // 
            gbInformacion.Controls.Add(NupDias);
            gbInformacion.Controls.Add(NupDistancia);
            gbInformacion.Controls.Add(lblDias);
            gbInformacion.Controls.Add(lblDistancia);
            gbInformacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbInformacion.Location = new Point(72, 126);
            gbInformacion.Name = "gbInformacion";
            gbInformacion.Size = new Size(458, 274);
            gbInformacion.TabIndex = 1;
            gbInformacion.TabStop = false;
            gbInformacion.Text = "Información Solicitada";
            // 
            // NupDias
            // 
            NupDias.Location = new Point(265, 161);
            NupDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            NupDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NupDias.Name = "NupDias";
            NupDias.Size = new Size(120, 25);
            NupDias.TabIndex = 3;
            NupDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // NupDistancia
            // 
            NupDistancia.DecimalPlaces = 2;
            NupDistancia.Location = new Point(265, 71);
            NupDistancia.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NupDistancia.Name = "NupDistancia";
            NupDistancia.Size = new Size(120, 25);
            NupDistancia.TabIndex = 2;
            NupDistancia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDias.Location = new Point(30, 161);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(181, 17);
            lblDias.TabIndex = 1;
            lblDias.Text = "Cantidad de días en estancia:";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDistancia.Location = new Point(33, 71);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(178, 17);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia al destino (en km):";
            // 
            // gpRespuestras
            // 
            gpRespuestras.Controls.Add(lstResultado);
            gpRespuestras.Controls.Add(lblPrecio);
            gpRespuestras.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gpRespuestras.Location = new Point(610, 126);
            gpRespuestras.Name = "gpRespuestras";
            gpRespuestras.Size = new Size(453, 274);
            gpRespuestras.TabIndex = 2;
            gpRespuestras.TabStop = false;
            gpRespuestras.Text = "Devolución";
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 17;
            lstResultado.Location = new Point(32, 121);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(278, 89);
            lstResultado.TabIndex = 1;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(20, 61);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(290, 30);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio de boleto ida y vuelta:";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(371, 415);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(159, 60);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(630, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(132, 60);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 496);
            label1.Name = "label1";
            label1.Size = new Size(571, 50);
            label1.TabIndex = 5;
            label1.Text = "\"La mejor opcion para tus viajes\"";
            // 
            // frmBoleteria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1125, 581);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(gpRespuestras);
            Controls.Add(gbInformacion);
            Controls.Add(lblTitulo);
            Name = "frmBoleteria";
            Text = "Boleteria";
            gbInformacion.ResumeLayout(false);
            gbInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NupDias).EndInit();
            ((System.ComponentModel.ISupportInitialize)NupDistancia).EndInit();
            gpRespuestras.ResumeLayout(false);
            gpRespuestras.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gbInformacion;
        private Label lblDias;
        private Label lblDistancia;
        private GroupBox gpRespuestras;
        private NumericUpDown NupDias;
        private NumericUpDown NupDistancia;
        private Label lblPrecio;
        private ListBox lstResultado;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label1;
    }
}
