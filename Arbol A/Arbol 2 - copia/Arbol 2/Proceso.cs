using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_2
{
    public class Proceso
    {
        public void TProceso()
        {
            Console.WriteLine("         Arbol No 2");

            Nodo NodoRaiz = new Nodo("G");//Creamos nuestro nodo raiz llamado empresa

            Arbol Arbolito = new Arbol();//Instanciamos nuestra clase TreeDiagrams

            //Colocamos el nodo raiz, nombre del nodo que buscamos y los nombres de los nodos que vamos a agregar en forma de array
            Arbolito.Add(NodoRaiz, "G", new string[] { "F", "A" });

            //Y repetimos hasta que quede el diagrama como quedamos
            Arbolito.Add(NodoRaiz, "A", new string[]
            { "B","C","D" });
            //Luego nadamas imprimimos el diagrama a partir del nodo raiz empresa
            Arbolito.Impresion(NodoRaiz);
            Arbolito.AlturayNivel();
            Console.ReadKey();
        }
    }
}
