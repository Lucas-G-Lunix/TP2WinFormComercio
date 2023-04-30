namespace AppComercio
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnListadoArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.btnModificarArticulos = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListadoArticulos
            // 
            this.btnListadoArticulos.Location = new System.Drawing.Point(245, 153);
            this.btnListadoArticulos.Name = "btnListadoArticulos";
            this.btnListadoArticulos.Size = new System.Drawing.Size(187, 23);
            this.btnListadoArticulos.TabIndex = 0;
            this.btnListadoArticulos.Text = "Listar Articulos";
            this.btnListadoArticulos.UseVisualStyleBackColor = true;
            this.btnListadoArticulos.Click += new System.EventHandler(this.btnListadoArticulos_Click);
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Location = new System.Drawing.Point(245, 182);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(187, 23);
            this.btnAgregarArticulos.TabIndex = 2;
            this.btnAgregarArticulos.Text = "Agregar Articulos";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnModificarArticulos
            // 
            this.btnModificarArticulos.Location = new System.Drawing.Point(245, 211);
            this.btnModificarArticulos.Name = "btnModificarArticulos";
            this.btnModificarArticulos.Size = new System.Drawing.Size(187, 23);
            this.btnModificarArticulos.TabIndex = 3;
            this.btnModificarArticulos.Text = "Modificar Articulos";
            this.btnModificarArticulos.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(245, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(235, 78);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(230, 55);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Comercio";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 469);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnModificarArticulos);
            this.Controls.Add(this.btnAgregarArticulos);
            this.Controls.Add(this.btnListadoArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoArticulos;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.Button btnModificarArticulos;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblTitulo;
    }
}

