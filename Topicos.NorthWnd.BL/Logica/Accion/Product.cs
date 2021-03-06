using System;
using System.Collections.Generic;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Accion
{
    internal class Product
    {
        public Model.Models.Product QryPorId(int elIdDeProducto)
        {
            var elRepositorio = new Logica.Repositorio.Product();
            var elResultado = elRepositorio.QryPorId(elIdDeProducto);
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorNombreAproximado(string elNombreDelProducto)
        {
            var elRepositorio = new Logica.Repositorio.Product();
            var elResultado = elRepositorio.QryPorNombreAproximado(elNombreDelProducto);
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior)
        {
            var elRepositorio = new Logica.Repositorio.Product();
            var elResultado = elRepositorio.QryPorRangoDePrecio(limiteInferior, limiteSuperior);
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorRangoProDescont(decimal limiteInferior, decimal limiteSuperior)
        {
            var elRepositorio = new Logica.Repositorio.Product();
            var elResultado = elRepositorio.QryPorRangoProDescont(decimal limiteInferior, decimal limiteSuperior);
            return elResultado;
        }

        public IList<Model.Models.Product> QryIdAproxProveedor(int idProveedor)
        {
            var elRepositorio = new Logica.Repositorio.Product();
            var elResultado = elRepositorio.QryPorRangoProDescont(int idProveedor);
            return elResultado;
        }

        public IList<Model.Models.Product> QryIdAproxCategoria(int idCategoria)
        {
            var elRepositorio = new Logica.Repositorio.Product();
            var elResultado = elRepositorio.QryPorRangoProDescont(int idCategoria);
            return elResultado;
        }

        public IList<Model.Models.Product> QryIdAproxEmpleadoJefatura(string empleadoJefatura)
        {
            var elRepositorio = new Logica.Repositorio.Product();
            var elResultado = elRepositorio.QryPorRangoProDescont(string empleadoJefatura);
            return elResultado;
        }

    }
}
