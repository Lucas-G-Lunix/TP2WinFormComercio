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
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                dgvMarcas.DataSource = marcaNegocio.listar();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                dgvCategorias.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
