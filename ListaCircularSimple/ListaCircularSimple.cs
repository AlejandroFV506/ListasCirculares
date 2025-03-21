using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularSimple
{
    public class ListaCircular
    {
        private Nodo cabeza;
        private int tamaño;

        public ListaCircular()
        {
            cabeza = null;
            tamaño = 0;
        }

        public void InsertarAlInicio(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (cabeza == null)
            {
                nuevoNodo.Siguiente = nuevoNodo; // Apunta a sí mismo
                cabeza = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = cabeza;
                Nodo temp = cabeza;
                while (temp.Siguiente != cabeza)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevoNodo;
                cabeza = nuevoNodo;
            }
            tamaño++;
        }

        public void InsertarAlFinal(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (cabeza == null)
            {
                nuevoNodo.Siguiente = nuevoNodo; // Apunta a sí mismo
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != cabeza)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = cabeza;
            }
            tamaño++;
        }

        public void InsertarEnPosicion(int valor, int indice)
        {
            if (indice < 0 || indice > tamaño)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango");
            }

            if (indice == 0)
            {
                InsertarAlInicio(valor);
            }
            else if (indice == tamaño)
            {
                InsertarAlFinal(valor);
            }
            else
            {
                Nodo nuevoNodo = new Nodo(valor);
                Nodo temp = cabeza;
                for (int i = 0; i < indice - 1; i++)
                {
                    temp = temp.Siguiente;
                }
                nuevoNodo.Siguiente = temp.Siguiente;
                temp.Siguiente = nuevoNodo;
                tamaño++;
            }
        }

        public void EliminarAlInicio()
        {
            if (cabeza == null)
            {
                throw new InvalidOperationException("La lista está vacía");
            }

            if (cabeza.Siguiente == cabeza)
            {
                cabeza = null;
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != cabeza)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = cabeza.Siguiente;
                cabeza = cabeza.Siguiente;
            }
            tamaño--;
        }

        public void EliminarAlFinal()
        {
            if (cabeza == null)
            {
                throw new InvalidOperationException("La lista está vacía");
            }

            if (cabeza.Siguiente == cabeza)
            {
                cabeza = null;
            }
            else
            {
                Nodo temp = cabeza;
                Nodo anterior = null;
                while (temp.Siguiente != cabeza)
                {
                    anterior = temp;
                    temp = temp.Siguiente;
                }
                anterior.Siguiente = cabeza;
            }
            tamaño--;
        }

        public void EliminarEnPosicion(int indice)
        {
            if (indice < 0 || indice >= tamaño)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango");
            }

            if (indice == 0)
            {
                EliminarAlInicio();
            }
            else if (indice == tamaño - 1)
            {
                EliminarAlFinal();
            }
            else
            {
                Nodo temp = cabeza;
                for (int i = 0; i < indice - 1; i++)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = temp.Siguiente.Siguiente;
                tamaño--;
            }
        }

        public int ObtenerTamaño()
        {
            return tamaño;
        }

        public override string ToString()
        {
            if (cabeza == null)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            Nodo temp = cabeza;
            do
            {
                sb.Append(temp.Valor);
                if (temp.Siguiente != cabeza)
                {
                    sb.Append(", ");
                }
                temp = temp.Siguiente;
            } while (temp != cabeza);

            return sb.ToString();
        }
    }
}

