namespace AppComercio
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.btnAdministrarMarcasCategorias = new System.Windows.Forms.Button();
            this.btnCambiarImagenDerecha = new System.Windows.Forms.Button();
            this.btnCambiarImagenIzquierda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(549, 583);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(187, 36);
            this.btnEliminarArticulo.TabIndex = 2;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(27, 583);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(187, 36);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarArticulos.BackColor = System.Drawing.Color.Gold;
            this.btnModificarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArticulos.Location = new System.Drawing.Point(288, 583);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(187, 36);
            this.btnModificarArticulos.TabIndex = 1;
            this.btnModificarArticulos.Text = "Modificar Articulo";
            this.btnModificarArticulos.UseVisualStyleBackColor = false;
            this.btnModificarArticulos.Click += new System.EventHandler(this.btnModificarArticulos_Click);
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.Location = new System.Drawing.Point(452, 95);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(187, 23);
            this.btnDetalleArticulo.TabIndex = 5;
            this.btnDetalleArticulo.Text = "Detalle Articulo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(380, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(241, 63);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Comercio";
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(12, 132);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(644, 388);
            this.dgvArticulo.TabIndex = 6;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(697, 167);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(300, 300);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 7;
            this.pbxArticulo.TabStop = false;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(71, 543);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 6;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(12, 546);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 9;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(211, 546);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(269, 543);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboCriterio.TabIndex = 7;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(409, 546);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(80, 13);
            this.lblFiltroAvanzado.TabIndex = 12;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(508, 543);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(131, 20);
            this.txtFiltroAvanzado.TabIndex = 8;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 100);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(58, 13);
            this.lblFiltro.TabIndex = 14;
            this.lblFiltro.Text = "Filtro Veloz";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(76, 96);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(229, 20);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(668, 543);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroAvanzado.TabIndex = 9;
            this.btnFiltroAvanzado.Text = "Filtrar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // btnAdministrarMarcasCategorias
            // 
            this.btnAdministrarMarcasCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdministrarMarcasCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(181)))), ((int)(((byte)(171)))));
            this.btnAdministrarMarcasCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarMarcasCategorias.Location = new System.Drawing.Point(810, 583);
            this.btnAdministrarMarcasCategorias.Name = "btnAdministrarMarcasCategorias";
            this.btnAdministrarMarcasCategorias.Size = new System.Drawing.Size(187, 36);
            this.btnAdministrarMarcasCategorias.TabIndex = 3;
            this.btnAdministrarMarcasCategorias.Text = "Administrar Marcas/Categorias";
            this.btnAdministrarMarcasCategorias.UseVisualStyleBackColor = false;
            this.btnAdministrarMarcasCategorias.Click += new System.EventHandler(this.btnAdministrarMarcasCategorias_Click);
            // 
            // btnCambiarImagenDerecha
            // 
            this.btnCambiarImagenDerecha.Location = new System.Drawing.Point(1003, 303);
            this.btnCambiarImagenDerecha.Name = "btnCambiarImagenDerecha";
            this.btnCambiarImagenDerecha.Size = new System.Drawing.Size(29, 29);
            this.btnCambiarImagenDerecha.TabIndex = 15;
            this.btnCambiarImagenDerecha.Text = ">";
            this.btnCambiarImagenDerecha.UseVisualStyleBackColor = true;
            this.btnCambiarImagenDerecha.Click += new System.EventHandler(this.btnCambiarImagenDerecha_Click);
            // 
            // btnCambiarImagenIzquierda
            // 
            this.btnCambiarImagenIzquierda.Location = new System.Drawing.Point(662, 303);
            this.btnCambiarImagenIzquierda.Name = "btnCambiarImagenIzquierda";
            this.btnCambiarImagenIzquierda.Size = new System.Drawing.Size(29, 29);
            this.btnCambiarImagenIzquierda.TabIndex = 16;
            this.btnCambiarImagenIzquierda.Text = "<";
            this.btnCambiarImagenIzquierda.UseVisualStyleBackColor = true;
            this.btnCambiarImagenIzquierda.Click += new System.EventHandler(this.btnCambiarImagenIzquierda_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1034, 641);
            this.Controls.Add(this.btnCambiarImagenIzquierda);
            this.Controls.Add(this.btnCambiarImagenDerecha);
            this.Controls.Add(this.btnAdministrarMarcasCategorias);
            this.Controls.Add(this.btnFiltroAvanzado);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(997, 676);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App WinForm Grupo 11";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button btnDetalleArticulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.Button btnAdministrarMarcasCategorias;
        private System.Windows.Forms.Button btnCambiarImagenDerecha;
        private System.Windows.Forms.Button btnCambiarImagenIzquierda;
    }
}

