using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_C
{
    public class Arbol
    {
        int x = 0, y = 2, Altura = 0, Nivel = 0;
        public void AgregarNodo(Nodo nodo, string nombre, string[] nombres) // Metodo para agregar valores
        {
            int valor=nombres.Length;
            if (nodo.Nombres != null) // Si en el arreglo hay valor
            {
                foreach (Nodo item in nodo.Nombres)//Por cada nodo en el arreglo del nodo 
                {
                    AgregarNodo(item, nombre, nombres); // Va mandar llamar el metodo agregar 
                }
            }
            else  //Si no tiene valor
            {
                if (nodo.nombre == nombre) //Si el atributo name del nodo es igual al nombre que ingresamos en el metodo 
                {
                    nodo.Nombres = new Nodo[nombres.Length]; // EL arreglo inicializado sera de tamaño
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nodo.Nombres[i] = new Nodo(nombres[i]); //Y les creamos los nodos a las uniones con su nombre
                    }
                }
            }
        }
        public void ImprimirNodo(Nodo nodo)//Imprime el Nodo
        {

            if (nodo.Nombres != null) //Si en el arreglo no hay valor
            {
                Console.SetCursorPosition(x, y);
                Console.Write(nodo.nombre); // imprime el nombre del nodo
                x = x + 5;
                ++y;
                for (int i = 0; i < nodo.Nombres.Length; i++)// un ciclo for del 0 hasta el tamaño del arreglo
                {
                    ImprimirNodo(nodo.Nombres[i]); // MAndamos llamar el metodo imprimir nodo con el Nodo y el indice i
                }
                x += 5;
            }
            else//Si hay valor
            {
                Console.SetCursorPosition(x, y);
                Console.Write(nodo.nombre); // Imprimimos el atributo nombre del tipo nodo

                ++y; //Agregamos uno a y

            }
            Altura = (y - 2) / 2; // Altura es igual a la y-2 /2
            Nivel = Altura;//La altura es igual al nivel solo aqui
        }

        public void ArbolC()
        {
            Console.Clear();
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("Arbol C)");
            Nodo NodoRaiz = new Nodo("K");//Creamos nuestro nodo raiz llamado NodoRaiz       
            AgregarNodo(NodoRaiz, "K", new string[] { "B", "A", "C", "D" });  //Mandamos llamar el metodo Agregar Nodo, EL nodo Avanza y ponemos el nodo en el que nos vamos ubicando
            AgregarNodo(NodoRaiz, "D", new string[] { "I    J", "E", }); //No pude mandar llamr el nodo J desde I
            AgregarNodo(NodoRaiz, "E", new string[] { "F", "G" });
            AgregarNodo(NodoRaiz, "G", new string[] { "H" });
            ImprimirNodo(NodoRaiz); // Mandamos llamar el metodo Impresion e imprimimos el NodoRaiz como valor 
            ImprimirDatosC(); //Mandamos llamar EL metodo ImprimirDatos
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }


        public void ImprimirDatosC() // Imprime solo los datos del arbol C
        {
            Console.WriteLine("\n\n\nLa altura es: {0}", Altura - 1);
            Console.WriteLine("La ruta desde K hasta H es: K->D->E->G->H");
            Console.WriteLine("El nivel es: {0}", Nivel - 1);
            Console.WriteLine("La ruta desde K hasta C es: K->C");
            Console.WriteLine("La ruta desde K hasta H es: K->D->E->G->H");
            Console.WriteLine("La ruta desde K hasta J es: K->D->I->J");
        }

        public void ImpresionFinal() // SOlo imprime el menu
        {         
                ArbolC();
        }
    }
}

