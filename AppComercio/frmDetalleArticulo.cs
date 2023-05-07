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
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo = null;
        private int imagenActual;
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            lblCodigo.Text = articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblMarca.Text = articulo.Marca.ToString();
            lblCategoria.Text = articulo.Categoria.ToString();
            lblPrecio.Text = articulo.Precio.ToString();
            cargarImagen(articulo.ImagenURL[0]);
            imagenActual = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/original/icon-image-not-found-free-vector.jpg");

            }
        }

        private void btnCambiarImagenIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                cargarImagen(articulo.ImagenURL[imagenActual - 1]);
                imagenActual--;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (NullReferenceException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCambiarImagenDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                cargarImagen(articulo.ImagenURL[imagenActual + 1]);
                imagenActual++;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (NullReferenceException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
