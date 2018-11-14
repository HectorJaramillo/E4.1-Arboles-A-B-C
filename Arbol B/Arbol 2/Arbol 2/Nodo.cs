using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_2
{
    public class Nodo//Clase nodo para cada vertice del arbol
    {
        public string Nombre;//Nombre del nodo
        public Nodo[] Union;//Uniones a otros nodos
        public Nodo(string nombre)//Un constructor donde se le tenga que introducir el nombre del nodo a crear
        {
            Nombre = nombre;
        }
    }
}
