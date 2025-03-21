using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleCircular
{
    public class listCircular
    {
        private Node tail = null; // cola de la lista
        public int Size { get; private set; } // # elementos lista

        public bool IsEmpty()
        {  
            return tail == null;
        }

        public void addFirst(int newElement)
        {
            Node newNode = new Node(newElement);

            if (IsEmpty())
            {
                // Si la lista está vacía, el nuevo nodo es el tail y se apunta a sí mismo
                tail = newNode;
                tail.Next = tail;
                tail.Previous = tail;
            }

            else
            {

                newNode.Next =tail.Next;        // siguiente nodo es el antiguo head
                newNode.Previous = tail;        // El anterior del nuevo nodo es el tail
                tail.Next.Previous = newNode;   // El anterior del antiguo head es el nuevo nodo
                tail.Next = newNode;            // El siguiente del tail es el nuevo nodo
            }

            Size++;

        }

        public void addLast(int newElement)
        {
            Node newNode = new Node(newElement);

            if (IsEmpty())
            {
                // Si la lista está vacía, el nuevo nodo es el tail y se apunta a sí mismo
                tail = newNode;
                tail.Next = tail;
                tail.Previous = tail;
            }
            else
            {
                newNode.Next = tail.Next;     // El siguiente del nuevo nodo es el head
                newNode.Previous = tail;      // El anterior del nuevo nodo es el antiguo tail
                tail.Next.Previous = newNode; // El anterior del head es el nuevo nodo
                tail.Next = newNode;          // El siguiente del antiguo tail es el nuevo nodo
                tail = newNode;               // El nuevo nodo es ahora el tail
            }

            Size++;
        }

        public void InsertAt(int value, int index)
        {
            if (index < 0 || index > Size)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango.");
            }

            if (index == 0)
            {
                addFirst(value);
            }
            else if (index == Size)
            {
                addLast(value);
            }
            else
            {
                Node newNode = new Node(value);
                Node current = tail.Next;               // Comienza desde el head (tail.Next)
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                newNode.Previous = current;
                current.Next.Previous = newNode;
                current.Next = newNode;

                Size++;
            }
        }

        public void DeleteFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("La lista esta vacia");
            }
            if (Size == 1)
            {
                tail = null;
            }
            else
            {
                tail.Next = tail.Next.Next;
                tail.Next.Previous = tail;
            }

            Size--;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("No se puede eliminar, la lista está vacía.");
            }

            if (Size == 1)
            {
                // Si solo hay un elemento, la lista queda vacía
                tail = null;
            }
            else
            {
                //El penúltimo nodo se convierte en el tail
                tail = tail.Previous;       // El penúltimo nodo es ahora el tail
                tail.Next = tail.Next.Next; // El siguiente del tail es el head
                tail.Next.Previous = tail;  // El anterior del head es el tail
            }

            Size--;
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= Size)
            {
                throw new ArgumentOutOfRangeException("Índice fuera de rango.");
            }

            if (index == 0)
            {
                DeleteFirst();
            }
            else if (index == Size - 1)
            {
                DeleteLast();
            }
            else
            {
                Node current = tail.Next;  // Comienza desde el head
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Previous.Next = current.Next;
                current.Next.Previous = current.Previous;

                Size--;
            }
        }

        //Obtener tamaño
        public int GetSize()
        {
            return Size;
        }

      
        public override string ToString()
        {
            if (IsEmpty())
            {
                return string.Empty;
            }

            string result = string.Empty;
            Node current = tail.Next;  // Comienza desde el head

            do
            {
                result += current.Data + ", ";
                current = current.Next;
            } 
            while (current != tail.Next);  // Recorre la lista hasta volver al head

            return result.TrimEnd(',', ' ');
        }
    }
}
