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
    public partial class FormArticulos : Form
    {
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void dgvArticulos_Load(object sender, EventArgs e)
        {
            ArticulosDatos datos = new ArticulosDatos();
            dgvArticulos.DataSource = datos.listar();
        }
    }
}
