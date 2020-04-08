using System;
using System.Collections.Generic;
using System.Text;

namespace curso_1
{
   public class listanodo
    {
        private Nodo primero;
        
        private int size;

        public listanodo()
        {
            primero = null;
            size = 0;
                

        }
        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato);//add el nodo
            Nodo valor1, valor2;
            if (primero ==null)

            {
                primero = nuevo;
                nuevo.siguiente = null;
            }else
            {
                valor1 = primero;
                while(valor1!= null)
                {
                    valor2 = valor1.siguiente;
                    //condicion que verifica si el numero entrante debe ir de primero
                    if (nuevo.dato <= valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else
                    {
                        //condicion que verifica si elnumero entrante debe ir de ultimo
                        if (nuevo.dato> valor1.dato && valor2==null)
                        {
                            valor1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            //condicion que verifica si el numero entrante debe de ir en medio de otro nodo
                            if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
                            {
                                valor1.siguiente = nuevo;
                                nuevo.siguiente = valor2;
                                break;
                            }
                            else
                            {
                                valor1 = valor1.siguiente;
                            }
                        }
                    }
                }
            }
            size++;
        }
        public void ListaVacia()
        {
            if (primero==null)
            {
                Console.WriteLine("lalista esta vacia");

            }
            else
            {
                Console.WriteLine("la lista tiene datos");

            }
        }
        public void listar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.Write($"[{actual.dato}]->");
                actual = actual.siguiente;
            }
        }
        public void deleteprimero()
        {
            primero = primero.siguiente;//elimina el primer nodo
        }
        public void deleteultimo()
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            while (actual.siguiente != null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
            anterior.siguiente = null;
        }
        public void deleteposicionnodo(int p)
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            int dato = 0;
            if (p>0)
            {
                while (dato != p && actual.siguiente !=null)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                    dato++;
                }
                anterior.siguiente = actual.siguiente;
            }
        }
        public Nodo buscar(int n)
        {
            Nodo p = primero;
            if (primero== null)

            {
                Console.WriteLine("lalista no tiene datos");
            }
            else
            {
                while (p.siguiente != null || p.siguiente ==null)
                {
                    if (p.dato ==n)
                    {
                        return p;
                    }
                    else
                    {
                        if (p.siguiente == null)
                        {
                            return null;
                        }
                    }
                    p = p.siguiente;
                }

            }
            return null;
        }
        public void sustitur(int origin, int nuevo)
        {
            Nodo pos = buscar(origin);
            if (pos != null || pos == null)
            {
                pos.dato = nuevo;
            }
        }
        public int Size()
        {
            return size;
        }
    }
}
