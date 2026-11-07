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
            pnlDatos = new Panel();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            lblTelefono = new Label();
            txtDocumento = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblDocumento = new Label();
            txtExistencias = new TextBox();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvUsuarios = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(537, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(241, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÒN USUARIOS";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(txtCorreo);
            pnlDatos.Controls.Add(txtTelefono);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblCorreo);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(txtDocumento);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(txtApellido);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(lblDocumento);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 53);
            pnlDatos.Margin = new Padding(0);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 311);
            pnlDatos.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(632, 255);
            txtCorreo.Margin = new Padding(0);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(157, 23);
            txtCorreo.TabIndex = 24;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(632, 206);
            txtTelefono.Margin = new Padding(0);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(157, 23);
            txtTelefono.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(632, 42);
            txtNombre.Margin = new Padding(0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 22;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(492, 258);
            lblCorreo.Margin = new Padding(0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(60, 20);
            lblCorreo.TabIndex = 21;
            lblCorreo.Text = "Correo:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(492, 209);
            lblTelefono.Margin = new Padding(0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 20);
            lblTelefono.TabIndex = 20;
            lblTelefono.Text = "Telefono:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(632, 149);
            txtDocumento.Margin = new Padding(0);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(157, 23);
            txtDocumento.TabIndex = 19;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(492, 45);
            lblNombre.Margin = new Padding(0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(632, 94);
            txtApellido.Margin = new Padding(0);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(157, 23);
            txtApellido.TabIndex = 17;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(492, 97);
            lblApellido.Margin = new Padding(0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 20);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(492, 152);
            lblDocumento.Margin = new Padding(0);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(95, 20);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento:";
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(581, 240);
            txtExistencias.Margin = new Padding(0);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(157, 23);
            txtExistencias.TabIndex = 18;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(207, 383);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(913, 47);
            pnlBotones.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelar.IconSize = 20;
            btnCancelar.Location = new Point(734, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEliminar.IconSize = 20;
            btnEliminar.Location = new Point(556, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 39);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEditar.IconSize = 20;
            btnEditar.Location = new Point(375, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 40);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardar.IconSize = 20;
            btnGuardar.Location = new Point(199, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnNuevo.IconSize = 20;
            btnNuevo.Location = new Point(27, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(149, 40);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Bottom;
            dgvUsuarios.Location = new Point(0, 455);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1350, 362);
            dgvUsuarios.TabIndex = 10;
            dgvUsuarios.CellContentDoubleClick += dgvUsuarios_CellContentDoubleClick;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 817);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlDatos;
        private TextBox txtISBN;
        private TextBox txtExistencias;
        private TextBox txtTitulo;
        private Label lblIsbn;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtAño;
        private TextBox txtCategoria;
        private Label lblExistencias;
        private Label lblAño;
        private Label lblCategoria;
        private Label lblEditorial;
        private Label lblApellido;
        private Label lblDocumento;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Label lblNombre;
        private Label lblCorreo;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Panel pnlBotones;
        protected internal FontAwesome.Sharp.IconButton btnCancelar;
        protected internal FontAwesome.Sharp.IconButton btnEliminar;
        protected internal FontAwesome.Sharp.IconButton btnEditar;
        protected internal FontAwesome.Sharp.IconButton btnGuardar;
        protected internal FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvUsuarios;
    }
}