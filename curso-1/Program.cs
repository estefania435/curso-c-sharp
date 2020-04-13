using System;
using System.Collections.Generic;
using System.Text;

namespace curso_1
{
    class Program : Menu
    {
        //metodo constructor
        public Program(string s): base(s)//hace referencia a almetodo constructor de la clase que estamos heredando(menu)
        {

        }
        static void Main()
        {

            new Program("emprea sd").getproducto();  
            Console.ReadKey();
        }
        //override indica a la clase program que el metodo ha sido sobreescrito de la clase que esta heredando
       
        protected override void getproducto()
        {
            Console.WriteLine("hola");
        }
    }
}
