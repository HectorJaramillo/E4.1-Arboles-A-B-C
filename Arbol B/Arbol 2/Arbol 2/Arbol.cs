using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_2
{
    public class Arbol
    {
        //Cordenadas para la impresion
        int x = 0, y = 2;

        public void Add(Nodo nodo, string nombre, string[] nombres)//Aqui añadimos uniones a lo que serian las hojas del arbol para convertirlas en ramas
        {//Le ingresamos el nodo raiz, nombre del nodo que buscamos y los nombres de las uniones que vamos a crear en ese nodo(uno por nodo)
            if (nodo.Union != null)//Si el nodo no es nulo
            {
                foreach (Nodo item in nodo.Union)//Por cada nodo union dentro del nodo original
                {
                    Add(item, nombre, nombres);//Aplicamos recursividad del mismo metodo
                }
            }
            else//Si no tienen uniones
            {
                if (nodo.Nombre == nombre)//Checamos si es el nombre que buscamos y si lo es
                {
                    nodo.Union = new Nodo[nombres.Length];//Creamos las uniones equivalente al numero de nombres que ingresamos
                    for (int i = 0; i < nombres.Length; i++)
                    {
                        nodo.Union[i] = new Nodo(nombres[i]);//Y les creamos los nodos a las uniones con su nombre
                    }
                }
            }
        }
        int Altura = 0, Nivel = 0;
        public void Impresion(Nodo nodo)//Imprime el digrama de todas las uniones
        {

            if (nodo.Union != null)//Si no es nulo
            {
                Console.SetCursorPosition(x, y);//colocamos el cursor en las cordenada x,y
                Console.Write(nodo.Nombre);//Y escribimos el nombre de la rama
                x = x + 5;//Como sabemos que es una rama pues la diferenciamos un un cambio de posicion en x y sumamos uno en y
                ++y;
                for (int i = 0; i < nodo.Union.Length; i++)//Por cada union vamos a llamar el mismo metodo para asi llegar a todas partes del diagrama
                {
                    Impresion(nodo.Union[i]);
                }
                x += 5;
            }

            else//Si no es nulo significa que llegamos a una hoja y ya no hay a donde ir
            {
                Console.SetCursorPosition(x, y);//Colocamos de nuevo el cursor en las cordenadas que llevamos
                Console.Write(nodo.Nombre);//Escribimos el nombre de la hoja
                ++y;//Y agregamos una posicion en y

            }
            Nivel = (y - 2) / 2;//Como el valor de y es 2 por eso le resto 2 y como cada vez que se le suman 2 significa que se le aumento una rama lo divido entre 2 me da el nivel
            Altura = Nivel + 1;//El nivel +1 me da la altura
        }
        public void AlturayNivel()
        {
            Console.WriteLine("\nLa altura es: {0}", Altura);
            Console.WriteLine("El nivel es: {0}", Nivel);
            Console.WriteLine("La ruta al ultimo elemento es C-->A-->B-->E");
        }
    }
}
