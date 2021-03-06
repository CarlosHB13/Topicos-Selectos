using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.BL.Logica.Interface;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Servicio
{
    public class NWProduct : IProduct
    {
        public Product QryPorId(int elIdDeProducto)
        {
            var laAccion = new Logica.Accion.Product();
            var elResultado = laAccion.QryPorId(elIdDeProducto);
            return elResultado;
        }

        public IList<Product> QryPorNombreAproximado(string elNombreDelProducto)
        {
            var laAccion = new Logica.Accion.Product();
            var elResultado = laAccion.QryPorNombreAproximado(elNombreDelProducto);
            return elResultado;
        }

        public IList<Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior)
        {
            var laAccion = new Logica.Accion.Product();
            var elResultado = laAccion.QryPorRangoDePrecio(limiteInferior, limiteSuperior);
            return elResultado;
        }

        public IList<Product> QryPorRangoProDescont(decimal limiteInferior, decimal limiteSuperior)
        {
            var laAccion = new Logica.Accion.Product();
            var elResultado = laAccion.QryPorRangoProDescont(limiteInferior, limiteSuperior);
            return elResultado;        
        }

        public IList<Product> QryIdAproxProveedor(int idProveedor)
        {
            var laAccion = new Logica.Accion.Product();
            var elResultado = laAccion.QryIdAproxProveedor(idProveedor);
            return elResultado;
        }

        public IList<Product> QryIdAproxCategoria(int idCategoria)
        {
            var laAccion = new Logica.Accion.Product();
            var elResultado = laAccion.QryIdAproxCategoria(idCategoria);
            return elResultado;
        }

        public IList<Product> QryIdAproxEmpleadoJefatura(string empleadoJefatura)
        {
            var laAccion = new Logica.Accion.Product();
            var elResultado = laAccion.QryIdAproxEmpleadoJefatura(empleadoJefatura);
            return elResultado;
        }

    }
}
