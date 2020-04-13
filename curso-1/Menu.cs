using System;
using System.Collections.Generic;
using System.Text;

namespace curso_1
{
    public class Menu
    {
        private string s;

        public Menu(string s)
        {
            this.s = s;
        }
        //portecte significa que esta clase puede utilizar el metodoy las clases derivadas tambien
        //virtual para anular el metodo y cambiarlo en la clase program
        protected virtual void getproducto()
        {
            Console.WriteLine(s);
        }

    }
}
