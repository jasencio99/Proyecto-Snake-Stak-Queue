using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaCircular
    {

        private static int fin;
        private static int MAXTAMQ = 9999;
        protected int frente;
        protected Object[] listaCola;
        public int tamaño;

        // avanza una posición

        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new object[MAXTAMQ];
        }

        // Validaciones
        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }

        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }

        //operaciones de modificacion de cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;
                tamaño++;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }


        }
        // quitar elemento
        public Object quitar()
        {
            if (!colaVacia())
            {
                Object tm = listaCola[frente];
                frente = siguiente(frente);
                tamaño--;
                return tm;
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

        public void borrarCola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
        }

        //obtener el valor de frente
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

        public Object finalCola()
        {
            if (!colaVacia())
            {
                return listaCola[fin];
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
        }

        public int Tamaño()
        {
            int tama;
            tama = tamaño;
            return tamaño;
        }
        public bool comprobar(int x, int y)
        {
            int con = 0;
            bool b;
            int i = 0;


            while (i <= fin)
            {
                Point p = (Point)listaCola[i];
                b = (p.X != x && p.Y != y);
                if (b == true)
                {
                    con++;
                }
                else
                {
                    con = con + 0;
                }
                i++;
            }
            return (con != 0) ? true : false;
        }

        public bool comprobarany(Point z)
        {
            bool encontrado = false;
            for (int i = 0; i < Tamaño(); i++)
            {
                Point dato = (Point)listaCola[i];//Posicion 0 por eso ponemos i
                if (dato.X == z.X && dato.Y == z.Y)
                {
                    encontrado = true;
                }
                dato = new Point();
            }
            return encontrado;
        }

        public int numElementosLista()
        {
            return fin -1;
        }

    }//end class
}
