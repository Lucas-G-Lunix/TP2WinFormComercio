using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComercio
{
    internal class ArticulosDatos : Articulo
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=localhost\\SQLEXPRESS;database=CATALOGO_P3_DB;Trusted_Connection=True";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT Id, Codigo, Nombre, Descripcion FROM ARTICULOS";
                command.Connection = conexion;
                conexion.Open();
                lector = command.ExecuteReader();

                while (lector.Read())
                {
                    Articulo articuloAux = new Articulo();
                    articuloAux.Id = int.Parse(lector.GetInt32(0).ToString());
                    articuloAux.CodigoArticulo = (string)lector["Codigo"];
                    articuloAux.Nombre = (string)lector["Nombre"];
                    articuloAux.Descripcion = (string)lector["Descripcion"];
                    lista.Add(articuloAux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}
