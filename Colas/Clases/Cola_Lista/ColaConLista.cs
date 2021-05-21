using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Colas.Clases.Cola_Lista
{
    class ColaConLista
    {
        protected Nodo frente;
        protected Nodo fin;

        //constructor: crear la cola vacía
        public ColaConLista()
        {
            frente = fin = null;
        }

        //verificar si la cola está vacía
        public bool colaVacia()
        {
            return (frente == null);
        }

        //insertar: pone elmento por el final de la cola
        public void insertar(Object elemento)
        {
            Nodo a;
            a = new Nodo(elemento);
            if (colaVacia())
            {
                frente = a;
            }
            else
            {
                fin.siguiente = a;
            }
            fin = a;
        }

        //quitar un elemento
        public Object quitar()
        {
            Object aux;
            if (!colaVacia())
            {
                aux = frente.elemento;
                frente = frente.siguiente;
            }
            else
            {
                throw new Exception("Error porque la cola está vacía");
            }
            return aux;
        }

        //vaciar la cola, o liberrar todos los nodos
        public void borrarCola()
        {
            for (; frente != null;)
            {
                frente = frente.siguiente;
            }
        }

        //devolver el valor que está al frente de la cola
        public Object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error la cola está vacía");
            }
            return (frente.elemento);
        }

        public Object finalCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error la cola está vacía");
            }
            return (fin.elemento);
        }

        public bool comprobar(int x, int y)
        {
            int con = 0;
            bool b;

            Nodo aux = frente;

            while (aux != null)
            {
                Point p = (Point)aux.elemento;
                b = (p.X != x && p.Y != y);
                if (b == true)
                {
                    con=con+0;
                }
                else
                {
                    con++;
                }
                aux = aux.siguiente;
            }
            return (con == 0) ? true : false;
        }

        public bool comprobarany(Point z)
        {
            int con = 0;
            bool b;

            Nodo aux = frente;

            while (aux != null)
            {
                Point p = (Point)aux.elemento;
                b = (p.X == z.X && p.Y == z.Y);
                if (b == true)
                {
                    con++;
                }
                else
                {
                    con=con+0;
                }
                aux = aux.siguiente;
            }
            return (con != 0) ? true : false;
        }

        public int numElementosLista()
        {
            int n;
            Nodo a = frente;
            if (colaVacia())
            {
                n = 0;
            }
            else
            {
                n = 1;
                while (a != fin)
                {
                    n++;
                    a = a.siguiente;
                }
            }
            return n;
        }
    }//end class
}
