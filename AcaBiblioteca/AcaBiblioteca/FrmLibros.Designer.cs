namespace AcaBiblioteca
{
    partial class FrmLibros
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
            components = new System.ComponentModel.Container();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlDatos = new Panel();
            lblAnio = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblLibro = new Label();
            lblIsbn = new Label();
            lblExistencias = new Label();
            txtISBN = new TextBox();
            txtTitulo = new TextBox();
            txtCategoria = new TextBox();
            txtAnio = new TextBox();
            txtExistencias = new TextBox();
            cmbAutor = new ComboBox();
            cmbEditorial = new ComboBox();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.LightBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(286, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestion De Libros";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = SystemColors.ButtonFace;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(800, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(664, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(176, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(416, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(75, 21);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(35, 14);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAnio);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblLibro);
            pnlDatos.Controls.Add(lblIsbn);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(800, 300);
            pnlDatos.TabIndex = 2;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnio.Location = new Point(75, 203);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(35, 14);
            lblAnio.TabIndex = 6;
            lblAnio.Text = "Año:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(75, 168);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 14);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(75, 136);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(77, 14);
            lblEditorial.TabIndex = 4;
            lblEditorial.Text = "Editorial:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(75, 100);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(49, 14);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Autor:";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(75, 59);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(56, 14);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Titulo:";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsbn.Location = new Point(75, 28);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(42, 14);
            lblIsbn.TabIndex = 1;
            lblIsbn.Text = "ISBN:";
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(75, 235);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(91, 14);
            lblExistencias.TabIndex = 7;
            lblExistencias.Text = "Existencias:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(176, 19);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(416, 23);
            txtISBN.TabIndex = 3;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(176, 55);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(416, 23);
            txtTitulo.TabIndex = 8;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(176, 164);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(416, 23);
            txtCategoria.TabIndex = 11;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(176, 199);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(416, 23);
            txtAnio.TabIndex = 12;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(176, 231);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(416, 23);
            txtExistencias.TabIndex = 13;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(176, 91);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(416, 23);
            cmbAutor.TabIndex = 14;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(176, 132);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(416, 23);
            cmbEditorial.TabIndex = 15;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private ContextMenuStrip contextMenuStrip1;
        private Panel pnlDatos;
        private Label lblLibro;
        private Label lblIsbn;
        private Label lblAnio;
        private Label lblCategoria;
        private Label lblEditorial;
        private Label lblAutor;
        private Label lblExistencias;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtExistencias;
        private TextBox txtAnio;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
    }
}