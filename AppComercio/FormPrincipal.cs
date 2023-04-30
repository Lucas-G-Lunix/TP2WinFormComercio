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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnListadoArticulos_Click(object sender, EventArgs e)
        {
            FormArticulos articulos = new FormArticulos();
            articulos.ShowDialog();
        }
    }
}
