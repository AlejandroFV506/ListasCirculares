using ListaCircularSimple;
using System.Data.Common;
class program
{
    static void Main(string[] args)
    {
        ListaCircular lista = new ListaCircular();

        lista.InsertarAlFinal(1);
        Console.WriteLine("Se agrego al final el numero 1: " + lista);
        lista.InsertarAlFinal(2);
        Console.WriteLine("Se agrego al final el numero 2: " + lista);
        lista.InsertarAlFinal(3);
        Console.WriteLine("Se agrego al final el numero 3: " + lista);
        lista.InsertarAlInicio(0);
        Console.WriteLine("se agrego al inicio el numero 0: " + lista);
        lista.InsertarAlInicio(7);
        Console.WriteLine("se agrego al inicio el numero 7: " + lista);
        lista.InsertarEnPosicion(4, 2);
        Console.WriteLine("se agrego el numero 4 en la posicion 2 de la lista: " + lista);
        Console.WriteLine("La lista resultante es: " + lista.ToString()); // Output: 7, 0, 4, 1, 2, 3
        int tamaño = lista.ObtenerTamaño(); // Output: 6
        Console.WriteLine("El tamaño de la lista es de: "+ tamaño);
        lista.EliminarAlInicio();
        Console.WriteLine("se elimino el primer elemento de la lista: " + lista);
        lista.EliminarAlFinal();
        Console.WriteLine("se elimino el ultimo elemento de la lista: " + lista);
        lista.EliminarEnPosicion(1);
        Console.WriteLine("se elimino el elemento en la posicion 1 de la lista: " + lista);
        Console.WriteLine("La lista resultante es: " + lista.ToString()); // Output: 0, 1, 2
        tamaño = lista.ObtenerTamaño();
        Console.WriteLine("El tamaño de la lista es de: "+ tamaño); // Output: 3   
    }
}


