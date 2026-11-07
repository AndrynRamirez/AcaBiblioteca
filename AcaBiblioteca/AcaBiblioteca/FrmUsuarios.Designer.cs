namespace AcaBiblioteca
{
    partial class FrmUsuarios
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
            pnlCrud = new Panel();
            btnCancelar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblDocumento = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvUsuarios = new DataGridView();
            pnlTabla = new Panel();
            pnlTitulo.SuspendLayout();
            pnlCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnlTabla.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.DarkSlateBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.ForeColor = Color.White;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(800, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Unispace", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(298, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(259, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestion de Usuarios";
            // 
            // pnlCrud
            // 
            pnlCrud.Controls.Add(btnCancelar);
            pnlCrud.Controls.Add(btnEliminar);
            pnlCrud.Controls.Add(btnEditar);
            pnlCrud.Controls.Add(btnGuardar);
            pnlCrud.Controls.Add(btnNuevo);
            pnlCrud.Controls.Add(txtCorreo);
            pnlCrud.Controls.Add(txtTelefono);
            pnlCrud.Controls.Add(txtDocumento);
            pnlCrud.Controls.Add(txtApellido);
            pnlCrud.Controls.Add(txtNombre);
            pnlCrud.Controls.Add(lblCorreo);
            pnlCrud.Controls.Add(lblTelefono);
            pnlCrud.Controls.Add(lblDocumento);
            pnlCrud.Controls.Add(lblApellido);
            pnlCrud.Controls.Add(lblNombre);
            pnlCrud.Dock = DockStyle.Top;
            pnlCrud.Location = new Point(0, 60);
            pnlCrud.Name = "pnlCrud";
            pnlCrud.Size = new Size(800, 225);
            pnlCrud.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(591, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(463, 176);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(337, 176);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(226, 176);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(119, 176);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(337, 133);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(251, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(337, 101);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(251, 23);
            txtTelefono.TabIndex = 8;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(337, 72);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(251, 23);
            txtDocumento.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(337, 42);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(251, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(337, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(226, 136);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(43, 15);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(226, 109);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(226, 75);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(70, 15);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(226, 45);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(226, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(800, 165);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.DoubleClick += dgvUsuarios_DoubleClick;
            // 
            // pnlTabla
            // 
            pnlTabla.Controls.Add(dgvUsuarios);
            pnlTabla.Dock = DockStyle.Fill;
            pnlTabla.Location = new Point(0, 285);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(800, 165);
            pnlTabla.TabIndex = 2;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlTabla);
            Controls.Add(pnlCrud);
            Controls.Add(pnlTitulo);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlCrud.ResumeLayout(false);
            pnlCrud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnlTabla.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlCrud;
        private Label lblDocumento;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDocumento;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblCorreo;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvUsuarios;
        private Panel pnlTabla;
    }
}