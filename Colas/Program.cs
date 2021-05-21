using Colas.Clases.BicolaEnlazada;
using Colas.Clases.ColaArreglo;
using Colas.Clases.culebrita;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;
using System.Drawing;

namespace Colas
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("\n\tCULEBRITA COMELONA\n");
            Console.WriteLine("\tCon que tipo de cola desea jugar?\n");
            Console.WriteLine("\t1. Bicola");
            Console.WriteLine("\t2. Cola con Lista");
            Console.WriteLine("\t3. Cola Lineal");
            Console.WriteLine("\t4. Cola Circular");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    CulebraBiCola cbc = new CulebraBiCola();
                    cbc.funcionprincipal();
                    break;
                case 2:
                    CulebraConLista ccl = new CulebraConLista();
                    ccl.funcionprincipal();
                    break;
                case 3:
                    CulebraLineal cl = new CulebraLineal();
                    cl.funcionprincipal();
                    break;
                case 4:
                    CulebraColaCircular ccc = new CulebraColaCircular();
                    ccc.funcionprincipal();
                    break;
            }                      
        }
    }
}