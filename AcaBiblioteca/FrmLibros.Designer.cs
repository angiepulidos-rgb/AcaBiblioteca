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
            lblBuscar = new Label();
            txtBuscarISBN = new TextBox();
            btnBuscar = new Button();
            pnlBusqueda = new Panel();
            pnlDatos = new Panel();
            txtISBN = new TextBox();
            txtExistencias = new TextBox();
            txtTitulo = new TextBox();
            lblIsbn = new Label();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtAño = new TextBox();
            txtCategoria = new TextBox();
            lblExistencias = new Label();
            lblAño = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblTituloLib = new Label();
            lblAutor = new Label();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            pnlBotones = new Panel();
            dgvLibros = new DataGridView();
            notifyIcon1 = new NotifyIcon(components);
            notifyIcon2 = new NotifyIcon(components);
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Margin = new Padding(0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(525, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(325, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÒN DE LIBROS";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(440, 24);
            lblBuscar.Margin = new Padding(0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(44, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN";
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(581, 21);
            txtBuscarISBN.Margin = new Padding(0);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(161, 23);
            txtBuscarISBN.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(797, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 30);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarISBN);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 53);
            pnlBusqueda.Margin = new Padding(0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 58);
            pnlBusqueda.TabIndex = 5;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(lblIsbn);
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtAño);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 111);
            pnlDatos.Margin = new Padding(0);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 286);
            pnlDatos.TabIndex = 6;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(585, 20);
            txtISBN.Margin = new Padding(0);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(157, 23);
            txtISBN.TabIndex = 19;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(585, 241);
            txtExistencias.Margin = new Padding(0);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(157, 23);
            txtExistencias.TabIndex = 18;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(585, 57);
            txtTitulo.Margin = new Padding(0);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(157, 23);
            txtTitulo.TabIndex = 17;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsbn.Location = new Point(440, 23);
            lblIsbn.Margin = new Padding(0);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(44, 20);
            lblIsbn.TabIndex = 3;
            lblIsbn.Text = "ISBN";
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(585, 130);
            cmbEditorial.Margin = new Padding(0);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(157, 23);
            cmbEditorial.TabIndex = 16;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(585, 92);
            cmbAutor.Margin = new Padding(0);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(157, 23);
            cmbAutor.TabIndex = 15;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(585, 205);
            txtAño.Margin = new Padding(0);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(157, 23);
            txtAño.TabIndex = 13;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(585, 167);
            txtCategoria.Margin = new Padding(0);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(157, 23);
            txtCategoria.TabIndex = 12;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(442, 244);
            lblExistencias.Margin = new Padding(0);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(85, 20);
            lblExistencias.TabIndex = 10;
            lblExistencias.Text = "Existencias";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(442, 208);
            lblAño.Margin = new Padding(0);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(42, 20);
            lblAño.TabIndex = 9;
            lblAño.Text = "Año:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(442, 170);
            lblCategoria.Margin = new Padding(0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(80, 20);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(442, 133);
            lblEditorial.Margin = new Padding(0);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(71, 20);
            lblEditorial.TabIndex = 7;
            lblEditorial.Text = "Editorial:";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(442, 60);
            lblTituloLib.Margin = new Padding(0);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(54, 20);
            lblTituloLib.TabIndex = 6;
            lblTituloLib.Text = "Titulo:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(442, 95);
            lblAutor.Margin = new Padding(0);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(55, 20);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "Autor:";
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
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(208, 400);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(913, 50);
            pnlBotones.TabIndex = 7;
            // 
            // dgvLibros
            // 
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(97, 467);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 62;
            dgvLibros.Size = new Size(1146, 306);
            dgvLibros.TabIndex = 4;
            dgvLibros.CellContentDoubleClick += dgvLibros_CellContentDoubleClick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            notifyIcon2.Text = "notifyIcon2";
            notifyIcon2.Visible = true;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 817);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Margin = new Padding(0);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Label lblISNB;
        private Label lblBuscar;
        private TextBox txtBuscarISBN;
        private Button btnBuscar;
        private Panel pnlBusqueda;
        private Panel pnlDatos;
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
        private Label lblTituloLib;
        private Label lblAutor;
        protected internal FontAwesome.Sharp.IconButton btnNuevo;
        protected internal FontAwesome.Sharp.IconButton btnGuardar;
        protected internal FontAwesome.Sharp.IconButton btnEditar;
        protected internal FontAwesome.Sharp.IconButton btnEliminar;
        protected internal FontAwesome.Sharp.IconButton btnCancelar;
        private Panel pnlBotones;
        private DataGridView dgvLibros;
        private TextBox txtISBN;
        private NotifyIcon notifyIcon1;
        private NotifyIcon notifyIcon2;
    }
}