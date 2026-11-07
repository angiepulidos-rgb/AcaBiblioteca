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
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGenerar = new FontAwesome.Sharp.IconButton();
            cmbTipoReporte = new ComboBox();
            lblTipoReporte = new Label();
            pnlDgv = new Panel();
            dgvReportes = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlOpciones.SuspendLayout();
            pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.RoyalBlue;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.ForeColor = Color.Transparent;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 100);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(538, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÒN DE REPORTES";
            // 
            // pnlOpciones
            // 
            pnlOpciones.BackColor = Color.WhiteSmoke;
            pnlOpciones.Controls.Add(btnLimpiar);
            pnlOpciones.Controls.Add(btnGenerar);
            pnlOpciones.Controls.Add(cmbTipoReporte);
            pnlOpciones.Controls.Add(lblTipoReporte);
            pnlOpciones.Dock = DockStyle.Top;
            pnlOpciones.Location = new Point(0, 100);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(1350, 299);
            pnlOpciones.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnLimpiar.IconSize = 20;
            btnLimpiar.Location = new Point(803, 159);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 40);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnGenerar.IconColor = Color.Black;
            btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGenerar.IconSize = 20;
            btnGenerar.Location = new Point(492, 159);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(142, 40);
            btnGenerar.TabIndex = 15;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(707, 59);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(245, 28);
            cmbTipoReporte.TabIndex = 1;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoReporte.Location = new Point(492, 66);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(133, 21);
            lblTipoReporte.TabIndex = 0;
            lblTipoReporte.Text = "Tipo De Reporte";
            // 
            // pnlDgv
            // 
            pnlDgv.BackColor = Color.White;
            pnlDgv.Controls.Add(dgvReportes);
            pnlDgv.Dock = DockStyle.Fill;
            pnlDgv.Location = new Point(0, 399);
            pnlDgv.Name = "pnlDgv";
            pnlDgv.Size = new Size(1350, 418);
            pnlDgv.TabIndex = 3;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(0, 0);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1350, 418);
            dgvReportes.TabIndex = 0;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 817);
            Controls.Add(pnlDgv);
            Controls.Add(pnlOpciones);
            Controls.Add(pnlTitulo);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReportes";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlOpciones.ResumeLayout(false);
            pnlOpciones.PerformLayout();
            pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlOpciones;
        private ComboBox cmbTipoReporte;
        private Label lblTipoReporte;
        protected internal FontAwesome.Sharp.IconButton btnLimpiar;
        protected internal FontAwesome.Sharp.IconButton btnGenerar;
        private Panel pnlDgv;
        private DataGridView dgvReportes;
    }
}