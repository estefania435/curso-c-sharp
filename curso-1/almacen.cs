using System;
using System.Collections.Generic;
using System.Text;

namespace curso_1
{
    //abstract no puede ser instanciada la clase
    //EN LA CLASE ABSTRACTA SOLO PODEMOS DECLARAR LOS METODOS NO PODEMOS IMPLEMENTARLOS
    public abstract class almacen
    {
        public abstract List<Producto> getProducto(string producto);
        public abstract void addProducto(Producto producto);

        

        
    }
}
