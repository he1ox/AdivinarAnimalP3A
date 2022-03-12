using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarAnimalP3A
{
    public class AdivinaAnimal
    {
        private static NodoArbol raiz;

        public AdivinaAnimal()
        {
            raiz = new NodoArbol("Elefante");
        }

        public void Jugar()
        {
            NodoArbol nodo = raiz;

            while (nodo != null)
            {
                if (nodo != null)
                {
                    if (nodo.izquierda != null)
                    {
                        //Hay una pregunta
                        Console.WriteLine(nodo.valor);
                        nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;
                    }
                    else
                    {
                        //Se tiene un animal
                        Console.WriteLine($"Debe de ser un {nodo.valor}? si/no");
                        if (respuesta())
                        {
                            Console.WriteLine("Gané!");
                        }
                        else
                        {
                            animalNuevo(nodo);
                        }
                        nodo = null;
                        return;
                    }
                }
            }

        } //fin del juego


        public bool respuesta()
        {
            while (true)
            {
                string respuesta = Console.ReadLine().ToLower().Trim();

                if (respuesta.Equals("si")) return true;
                if (respuesta.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser si o no");

            }
        }

        private void animalNuevo(NodoArbol nodo)
        {
            String animalNodo = (String)nodo.valor;
            Console.WriteLine("¿Cuál es el animal en el que estabas pensando?");
            String nuevoAnimal = Console.ReadLine();

            Console.WriteLine($"¿Qué pregunta con respuesta si/no se puede hacer para decir que es un {nuevoAnimal}");
            var pregunta = Console.ReadLine();
            NodoArbol nodoUno = new NodoArbol(animalNodo);
            NodoArbol nodoDos = new NodoArbol(nuevoAnimal);

            Console.WriteLine($"Para {nuevoAnimal} la respuesta sería si o no a la pregunta {pregunta}?");

            nodo.valor = $"{pregunta}?";

            //Respuesta es sí
            if (respuesta())
            {
                //True = lo inserta en la izquierda
                nodo.izquierda = nodoDos; //nuevoAnimal
                nodo.derecha = nodoUno; //animalNodo
            }
            else
            {
                nodo.izquierda = nodoUno;
                nodo.derecha = nodoDos;
            }
        }
    }
}
