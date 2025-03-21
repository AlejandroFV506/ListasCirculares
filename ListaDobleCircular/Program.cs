using System;
using ListaDobleCircular;

class Program
{
    static void Main()
    {
        var lista = new listCircular();

        //Insertar al inicio
        lista.addFirst(10);
        lista.addFirst(5);

        //Insertar al final
        lista.addLast(20);
        lista.addLast(30);

        //Insertar en una posición indicada
        lista.InsertAt(15, 2);  // Inserta 15 en la posición 2
        Console.WriteLine("Lista: " + lista.ToString());

        //Eliminar al inicio
        lista.DeleteFirst();
        Console.WriteLine("Eliminar al inicio: " + lista.ToString());

        //Eliminar al final
        lista.DeleteLast();
        Console.WriteLine("Eliminar al final: " + lista.ToString());  

        //Eliminar en una posición indicada
        lista.DeleteAt(1);  // Elimina el elemento en la posición 1 (15)
        Console.WriteLine("Eliminar en posición 1: " + lista.ToString());

        //Obtener tamaño
        Console.WriteLine("Tamaño de la lista: " + lista.GetSize());
    }
}