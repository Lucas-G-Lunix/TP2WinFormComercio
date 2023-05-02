using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace AppComercio
{
    public partial class frmArticulos : Form
    {

        private List<Articulo> listaArticulo;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
        }

       
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cargarGrilla()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dgvArticulo.DataSource = listaArticulo;
                ocultarColumnas();
                pictureBoxArticulo.Load(listaArticulo[0].ImagenURL);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString() + "falla grilla ");
            }
        }
        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenURL);
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulo.Columns["ImagenURL"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxArticulo.Load("https://aramar.com/wp-content/uploads/2017/05/aramar-suministros-para-el-vidrio-cristal-sin-imagen-disponible.jpg");

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            
                frmAltaArticulo alta = new frmAltaArticulo();
                alta.ShowDialog();
                cargarGrilla();

            
        }
    }
}
