using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppComercio
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private int imagenActual;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Precio");
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenURL[0].ToString());
                imagenActual = 0;
            }
        }

        private void cargarGrilla()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listar();
                dgvArticulo.DataSource = listaArticulos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString() + "falla grilla");
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulo.Columns["Id"].Visible = false;
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

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargarGrilla();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Seguro que queres eliminarlo?", "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargarGrilla();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionaste ningun articulo", "Error en la operacion");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No seleccionaste ningun articulo", "Error en la operacion");
                return;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;
            if (filtro.Length > 1)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) ||
                x.Marca.Descripcion.ToLower().Contains(filtro.ToLower()) ||
                x.Categoria.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnAdministrarMarcasCategorias_Click(object sender, EventArgs e)
        {
            frmAdministrar administrar = new frmAdministrar();
            administrar.ShowDialog();
            cargarGrilla();
        }

        private void btnCambiarImagenDerecha_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenURL[imagenActual + 1]);
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

        private void btnCambiarImagenIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenURL[imagenActual - 1]);
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

        private bool validarFiltroAvanzado()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("El campo esta vacio");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Ingrese solo numeros por favor");
                    return true;
                }
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                //
                if (!(char.IsNumber(caracter)) && !(caracter == '.'))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            if (validarFiltroAvanzado())
            {
                return;
            }
            List<Articulo> listaArticulos = new List<Articulo>();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listaArticulos = articuloNegocio.listar();
            try
            {
                Filtros filtros = new Filtros();
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulo.DataSource = filtros.filtrar(campo, criterio, filtro, listaArticulos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }
    }
}
