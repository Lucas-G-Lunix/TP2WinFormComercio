using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace AppComercio
{
    public partial class frmAdmnistrarMarca : Form
    {
        Marca marca = null;
        bool modificar = false;
        public frmAdmnistrarMarca()
        {
            InitializeComponent();
        }

        public frmAdmnistrarMarca(string mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = mensaje;
        }

        public frmAdmnistrarMarca(string mensaje, Marca marca, bool modificar)
        {
            InitializeComponent();
            lblTitulo.Text = mensaje;
            this.marca = marca;
            this.modificar = modificar;
        }

        private void frmAdmnistrarMessageBox_Load(object sender, EventArgs e)
        {
            try
            {
                if (modificar)
                {
                    txtNombre.Text = marca.Descripcion;
                }
                else
                {
                    marca = new Marca();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            marca.Descripcion = txtNombre.Text;
            if (modificar)
            {
                marcaNegocio.modificar(marca);
                MessageBox.Show("Modificado Correctamente!");
                Close();
            }
            else
            {
                marcaNegocio.agregar(marca);
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
