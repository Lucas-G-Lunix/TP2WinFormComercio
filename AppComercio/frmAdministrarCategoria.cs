using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComercio
{
    public partial class frmAdministrarCategoria : Form
    {
        Categoria categoria = null;
        bool modificar = false;
        public frmAdministrarCategoria()
        {
            InitializeComponent();
        }

        public frmAdministrarCategoria(string mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = mensaje;
        }

        public frmAdministrarCategoria(string mensaje, Categoria categoria, bool modificar)
        {
            InitializeComponent();
            lblTitulo.Text = mensaje;
            this.categoria = categoria;
            this.modificar = modificar;
        }

        private void frmAdministrarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (modificar)
                {
                    txtNombre.Text = categoria.Descripcion;
                }
                else
                {
                    categoria = new Categoria();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            categoria.Descripcion = txtNombre.Text;
            if (modificar)
            {
                categoriaNegocio.modificar(categoria);
                MessageBox.Show("Modificado Correctamente!");
                Close();
            }
            else
            {
                categoriaNegocio.agregar(categoria);
                MessageBox.Show("Agregado Correctamente!");
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
