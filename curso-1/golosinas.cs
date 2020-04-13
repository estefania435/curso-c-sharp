using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace curso_1
{
    public class golosinas : almacen
    {
        private List<Producto> _golosinas;
        public golosinas()
        {
            _golosinas = new List<Producto>();
        }
        public override void addProducto(Producto producto)
        {
            _golosinas.Add(producto);
        }

        public override List<Producto> getProducto(string producto)
        {
            var Golosinas = new List<Producto>();
            if (producto.Equals(""))
            {
                Golosinas = _golosinas;
            }
            else
            {
                Golosinas = _golosinas.Where(g => g.Nombre.Equals(producto)).ToList();

            }return Golosinas;
           
        }
    }
}
