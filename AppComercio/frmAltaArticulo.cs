using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;
using System.IO;
using System.Xml.Linq;

namespace AppComercio
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cbxMarca.DataSource = marcaNegocio.listar();
            cbxMarca.ValueMember = "Id";
            cbxMarca.DisplayMember = "Descripcion";
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = categoriaNegocio.listar();
            cbxCategoria.ValueMember = "Id";
            cbxCategoria.DisplayMember = "Descripcion";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
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
                articulo.Precio = int.Parse(txtPrecio.Text);
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.agregar(articulo);
                MessageBox.Show("Agregado Correctamente!");
                /*if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado Correctamente!");
                }
                else
                {
                    
                }
                */
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
    }
}
