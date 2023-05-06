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
            if (validacion())
            {
                return;
            }
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
        private bool validacion()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre esta vacio", "Error en el ingreso de datos");
                return true;
            }
            if (soloLetras(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese solo letras", "Error en el ingreso de datos");
                return true;
            }
            return false;
        }
        private bool soloLetras(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (char.IsNumber(caracter))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
