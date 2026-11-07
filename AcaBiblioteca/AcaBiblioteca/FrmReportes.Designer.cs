namespace AcaBiblioteca
{
    partial class FrmReportes
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlOpciones = new Panel();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            cmbTipoReporte = new ComboBox();
            lblReporte = new Label();
            pnlTabla = new Panel();
            dgvReportes = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlOpciones.SuspendLayout();
            pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.DarkSlateBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 60);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(339, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(116, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reportes";
            // 
            // pnlOpciones
            // 
            pnlOpciones.Controls.Add(btnLimpiar);
            pnlOpciones.Controls.Add(btnGenerar);
            pnlOpciones.Controls.Add(cmbTipoReporte);
            pnlOpciones.Controls.Add(lblReporte);
            pnlOpciones.Dock = DockStyle.Top;
            pnlOpciones.Location = new Point(0, 60);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(800, 150);
            pnlOpciones.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(463, 84);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(300, 84);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(142, 23);
            btnGenerar.TabIndex = 11;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(300, 28);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(305, 23);
            cmbTipoReporte.TabIndex = 4;
            // 
            // lblReporte
            // 
            lblReporte.AutoSize = true;
            lblReporte.Location = new Point(178, 31);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(88, 15);
            lblReporte.TabIndex = 3;
            lblReporte.Text = "TIpo de reporte";
            // 
            // pnlTabla
            // 
            pnlTabla.Controls.Add(dgvReportes);
            pnlTabla.Dock = DockStyle.Fill;
            pnlTabla.Location = new Point(0, 210);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(800, 240);
            pnlTabla.TabIndex = 3;
            // 
            // dgvReportes
            // 
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(0, 0);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(800, 240);
            dgvReportes.TabIndex = 1;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlTabla);
            Controls.Add(pnlOpciones);
            Controls.Add(pnlTitulo);
            Name = "FrmReportes";
            Text = "FrmReportes";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlOpciones.ResumeLayout(false);
            pnlOpciones.PerformLayout();
            pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlOpciones;
        private ComboBox cmbTipoReporte;
        private Label lblReporte;
        private Button btnLimpiar;
        private Button btnGenerar;
        private Panel pnlTabla;
        private DataGridView dgvReportes;
    }
}