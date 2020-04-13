using System;
using System.Collections.Generic;
using System.Text;

namespace curso_1
{
    public class Menu : IMenu
    {
        almacen g = new golosinas();
        public void Golosinas()
        {
            var des = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("venta de golosinas");
                if (g.getProducto("").Count.Equals(0))
                {
                    Console.WriteLine("no hay golosinas");
                    Console.WriteLine("desea agregar golosinas? precione la tecla s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        Console.WriteLine("cuantas golosinas va a agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva golosina");
                            Console.WriteLine("ingrese la id");
                            var id = Console.ReadLine();
                            Console.WriteLine("ingrese el nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("ingrese el precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            g.addProducto(new Producto
                            {
                                ID = id,
                                Nombre= nombre,
                                Precio=precio
                            
                            }) ;
                            ;
                            

                        }
                        Console.WriteLine("desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            valor = true;

                        }
                        else
                        {
                            valor = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("desea ir al inicio s/n");
                        des = Console.ReadLine();
                        if (des.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("venta de golosinas y frutas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("lista de golosinas");
                    foreach (var item in g.getProducto(""))
                    {
                        Console.WriteLine($"codigo {item.ID} golosina {item.Nombre} precio {item.Precio}");
                    }
                    Console.WriteLine("desea realizar venta de golosina? s/n");
                    des = Console.ReadLine();
                    if (des.Equals("s"))
                    {
                        ventas();
                    }
                    else
                    {
                        valor = false;
                    }
                }

            } while (valor);
        }

        public double solicitarpago()
        {
            bool pagocorrecto = false;
            double res = 0;
            while (!pagocorrecto)
            {
                Console.WriteLine("como desea pagar con 10, 5");
                res = double.Parse(Console.ReadLine());
                if (res !=5 && res != 10)
                {
                    Console.WriteLine("pago no valido");
                }
                else
                {
                    pagocorrecto = true;
                }
            }
            return res;
        }

        public void ventas()
        {
            double total = 0;
            string des = "";
            do
            {
                Console.WriteLine("ingrese el producto");
                string producto = Console.ReadLine();
                var productos = g.getProducto(producto);
                while (productos.Count.Equals(0))
                {
                    Console.WriteLine("golosina no disponible,porfavor seleccione otro.");
                    producto = Console.ReadLine();
                    productos = g.getProducto(producto);
                }
                Console.WriteLine($"sumonto a pagar es: {productos[0].Precio.ToString()} $ dolar");
                double pago = solicitarpago();
                while (pago < productos[0].Precio)
                {
                    Console.WriteLine("faltan" + (productos[0].Precio - pago).ToString() + " $ dolar");
                    pago += solicitarpago();
                }
                Console.WriteLine("su cambio: " + (pago - productos[0].Precio).ToString());
                total += productos[0].Precio;
                Console.WriteLine("su pago fue de: " + total.ToString() + " $ dolar");
                Console.WriteLine("desea realizar otra compra? s/n");
                des = Console.ReadLine();

            } while (des.Equals("s"));
        }
    }

}
