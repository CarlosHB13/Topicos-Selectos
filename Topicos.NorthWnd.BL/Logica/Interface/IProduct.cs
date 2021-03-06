using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Interface
{
    public interface IProduct
    {
        Product QryPorId(int elIdDeProducto);

        IList <Product> QryPorNombreAproximado(string elNombreDelProducto);

        IList<Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior);

        //Lista de todos los productos descontinuados por rango de precio.
        IList<Prduct> QryPorRangoProDescont(decimal limiteInferior, decimal limiteSuperior);

        //Lista de todos los productos por nombre aproximado del proveedor.
        IList <Product> QryIdAproxProveedor(int idProveedor);

        //Lista de todos los productos por nombre aproximado de la categoría.
        IList<Product> QryIdAproxCategoria(int idCategoria);

        //Lista de todos los empleados por nombre aproximado de la jefatura.
        IList<Product> QryIdAproxEmpleadoJefatura(string empleadoJefatura);
    }
}
