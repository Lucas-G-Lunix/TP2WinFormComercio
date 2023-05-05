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
    public partial class frmAdministrar : Form
    {
        public frmAdministrar()
        {
            InitializeComponent();
        }

        private void frmAdministrar_Load(object sender, EventArgs e)
        {
            try
            {
                cargarMarcas();
                cargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cargarCategorias()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            dgvCategorias.DataSource = categoriaNegocio.listar();
            dgvCategorias.Columns["Descripcion"].HeaderText = "Categoria";
            dgvCategorias.Columns["Descripcion"].Width = 155;
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void cargarMarcas()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            dgvMarcas.DataSource = marcaNegocio.listar();
            dgvMarcas.Columns["Descripcion"].HeaderText = "Marca";
            dgvMarcas.Columns["Descripcion"].Width = 155;
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdmnistrarMarca messageBox = new frmAdmnistrarMarca("Agregar Marca");
                messageBox.ShowDialog();
                cargarMarcas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                frmAdmnistrarMarca messageBox = new frmAdmnistrarMarca("Modificar Marca", seleccionada, true);
                messageBox.ShowDialog();
                cargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                marcaNegocio.eliminar(seleccionada.Id);
                cargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdministrarCategoria messageBox = new frmAdministrarCategoria("Agregar Categoria");
                messageBox.ShowDialog();
                cargarCategorias();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                frmAdministrarCategoria messageBox = new frmAdministrarCategoria("Modificar Categoria", seleccionada, true);
                messageBox.ShowDialog();
                cargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                categoriaNegocio.eliminar(seleccionada.Id);
                cargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
