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
                        //nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;
                    }
                    else
                    {
                        //Se tiene un animal
                        Console.WriteLine($"Debe de ser un {nodo.valor}");
                        if (respuesta())
                        {
                            Console.WriteLine("Gané!");
                        }
                        else
                        {
                            animalNuevo(nuevo);
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
    }
}
