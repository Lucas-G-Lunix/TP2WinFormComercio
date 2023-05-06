using Dominio;
using Negocio;
using System;
using System.Windows.Forms;

namespace AppComercio
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo art)
        {
            InitializeComponent();
            articulo = art;
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.ImagenURL;
                    cargarImagen(articulo.ImagenURL);
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                    Text = "Modificar Pokemon";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacion())
                {
                    return;
                }
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.ImagenURL = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                ArticuloNegocio negocio = new ArticuloNegocio();

                AccesoDatos datos = new AccesoDatos();
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Correctamente!");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Correctamente!");
                }
                /*
                 if (archivo != null && !(txtUrlImagen.Text.ToLower().Contains("http")))
                 {
                     File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                 }
                */
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {

        }

        private bool validacion()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("El campo codigo esta vacio", "Error en el ingreso de datos");
                return true;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre esta vacio", "Error en el ingreso de datos");
                return true;
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("El campo Descripcion esta vacio", "Error en el ingreso de datos");
                return true;
            }
            if (txtUrlImagen.Text == "")
            {
                MessageBox.Show("El campo Url Imagen esta vacio", "Error en el ingreso de datos");
                return true;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("El campo Precio esta vacio", "Error en el ingreso de datos");
                return true;
            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Por favor, ingrese solo numero en el precio", "Error en el ingreso de datos");
                return true;
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
