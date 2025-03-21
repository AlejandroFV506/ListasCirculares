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
        private Node Tail = null; // cola de la lista
        public int Size { get; private set; } // # elementos lista

        public bool IsEmpty()
        {  
            return Tail == null;
        }

        public void addFirst(int newElement)
        {
            Node newNode = new Node(newElement);

            if (IsEmpty())
            {

                Tail = newNode;
                Tail.Next = Tail;
                Tail.Previus = Tail;
            }

            else
            {

                newNode.Next = Tail.Next; // 
                newNode.Previus = Tail;
                Tail.Next.Previus = newNode;
                Tail.Next = newNode;
            }


        }
    }
}
