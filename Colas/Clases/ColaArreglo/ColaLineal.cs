using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {

        protected int fin;
        private static int MAXTAMQ = 9999;
        protected int frente;
        private int tamaño;

        protected Object[] listaCola;

        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new  Object[MAXTAMQ];
        }              

        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ-1;
        }

        //operaciones para trabajar con datos en la cola
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento;
                tamaño++;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //quitar elemento de la cola
        public Object quitar()
        {
            if (!colaVacia())
            {
                tamaño--;
                return listaCola[frente++];                
            }
            else
            {
                throw new Exception("Cola Vacía");
            }
            
        }

        //Limpiar toda la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //Acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                tamaño--;
                return listaCola[frente];                
            }
            else
            {
                throw new Exception("Cola Vacía");
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
            int tam;
            tam = tamaño;
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
                Point dato = (Point)listaCola[i];
                if (dato.X == z.X && dato.Y == z.Y)
                {
                    encontrado = true;
                }
                dato = new Point();
            }
            return encontrado;
        }

    }//end class
}
