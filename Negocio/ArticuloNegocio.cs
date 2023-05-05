using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(" SELECT A.Id, Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdCategoria, A.IdMarca, I.ImagenURL, M.Id IdMarca, M.Descripcion Marca, C.Id IdCategoria, C.Descripcion Categoria " +
                   "FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON I.Id = A.Id");
                datos.ejecutarLecura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["ImagenURL"] is DBNull))
                        aux.ImagenURL = (string)datos.Lector["ImagenURL"];

                    aux.Categoria = new Categoria();

                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    else
                    {
                        aux.Categoria.Descripcion = "Sin Categoria";
                    }

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];


                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void agregar(Articulo nuevo)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)"+
                    " VALUES ('"+nuevo.Codigo+"', '"+nuevo.Nombre+"', '"+nuevo.Descripcion+ "', @marcaId, @categoriaId, @precio)");
                datos.setearParametro("@marcaId", nuevo.Marca.Id);
                datos.setearParametro("@categoriaId", nuevo.Categoria.Id);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.ejecutarAccion();
                datos.cerrarConexion();
                datos = new AccesoDatos();
                nuevo.Id = datos.ultimoId();
                datos.cerrarConexion();
                datos = new AccesoDatos();
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, '"+nuevo.ImagenURL+"')");
                datos.setearParametro("@idArticulo", nuevo.Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET"
                    + "Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio WHERE Id = @id");
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idMarca", art.Marca.Id);
                datos.setearParametro("@idCategoria", art.Categoria.Id);
                datos.setearParametro("@precio", art.Precio);
                datos.setearParametro("@id", art.Id);
                datos.ejecutarAccion();
                datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = '@imagenURL' WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@imagenURL", art.ImagenURL);
                datos.setearParametro("@idArticulo", art.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @id");
                datos.setearParametro("@id", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
