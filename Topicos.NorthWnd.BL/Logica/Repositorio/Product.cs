using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Topicos.NorthWnd.Model.Models;

namespace Topicos.NorthWnd.BL.Logica.Repositorio
{
    internal class Product
    {
        private NorthWindContext _elContexto;

        public Product()
        {
                
        }
        public Product(NorthWindContext elContexto)
        {
            _elContexto = elContexto;
        }

        public Model.Models.Product QryPorId(int elIdDeProducto)
        {
            var laConsulta = _elContexto.Products.Find(elIdDeProducto);
            return laConsulta;
        }

        public IList<Model.Models.Product> QryPorNombreAproximado(string elNombreDelProducto)
        {
            // IQueryable
            var laConsulta = _elContexto.Products.Where(p => p.ProductName.Contains(elNombreDelProducto));
            laConsulta = laConsulta.OrderByDescending(p => p.ProductName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorRangoDePrecio(decimal limiteInferior, decimal limiteSuperior)
        {
            // IQueryable
            var laConsulta = _elContexto.Products.Where(p => p.UnitPrice >= limiteInferior && p.UnitPrice <= limiteSuperior);
            laConsulta = laConsulta.OrderBy(p => p.UnitPrice);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public IList<Model.Models.Product> QryPorRangoProDescont(decimal limiteInferior, decimal limiteSuperior)
        {
            var laConsulta = _elContexto.Products.Where(p => p.Discontinued >= limiteInferior && p.Discontinued <= limiteSuperior);
            laConsulta = laConsulta.OrderBy(p => p.Discontinued);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public IList<Model.Models.Product> QryIdAproxProveedor(int idProveedor)
        {
            var laConsulta = _elContexto.Products.Where(p => p.ProductName.Contains(idProveedor));
            laConsulta = laConsulta.OrderBy(p => p.ProductName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public IList<Product> QryIdAproxCategoria(int idCategoria)
        {
            var laConsulta = _elContexto.Products.Where(p => p.ProductName.Contains(idCategoria));
            laConsulta = laConsulta.OrderBy(p => p.ProductName);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

        public IList<Product> QryIdAproxEmpleadoJefatura(string empleadoJefatura)
        {
            var laConsulta = _elContexto.Products.Where(p => e.Employee.Contains(empleadoJefatura));
            laConsulta = laConsulta.OrderBy(p => e.Employee);
            var elResultado = laConsulta.ToList();
            return elResultado;
        }

    }
}
