using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarAnimalP3A
{
    /// <summary>
    /// Creación de un nodo
    /// </summary>
    public class NodoArbol
    {
        public Object valor;
        public NodoArbol izquierda;
        public NodoArbol derecha;

        /// <summary>
        /// Constructor inicializa nodos hijos en null
        /// </summary>
        public NodoArbol()
        {
            valor = izquierda = derecha = null;
        }

        /// <summary>
        /// Constructor que inicia el nodo con los valor dados como parametros
        /// </summary>
        /// <param name="valorNodo"></param>
        public NodoArbol(Object valorNodo)
        {
            izquierda = derecha = null;
            valor = valorNodo;
        }

        public NodoArbol(NodoArbol iz, Object valor, NodoArbol der)
        {
            this.valor = valor;
            izquierda = iz;
            derecha = der;
        }
    }
}
