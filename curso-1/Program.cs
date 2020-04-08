using System;
using System.Collections.Generic;
using System.Text;

namespace curso_1
{
    class Program
    {
        static void Main()
        {
            var list = new listanodo();
            list.ListaVacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            list.listar();
            list.sustitur(3,6);
            Console.WriteLine(list.Size());
            list.listar();
                
            Console.ReadKey();
        }
    }
}
