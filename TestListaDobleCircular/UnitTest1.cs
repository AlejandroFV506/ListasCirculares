using ListaDobleCircular;

namespace TestListaDobleCircular
{
    [TestClass]
    public class CircularDoublyLinkedListTests
    {
        [TestMethod]
        //La lista deberia estar vacia
        public void ListaNueva_()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            bool estaVacia = lista.IsEmpty();

            // Assert
            Assert.IsTrue(estaVacia, "Una lista nueva deber�a estar vac�a.");
        }

        [TestMethod]
        //Deberia agregar elemento al inicio
        public void AddFirst_()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.addFirst(10);

            // Assert
            Assert.IsFalse(lista.IsEmpty(), "La lista no deber�a estar vac�a despu�s de agregar un elemento.");
            Assert.AreEqual(1, lista.GetSize(), "El tama�o de la lista deber�a ser 1.");
            Assert.AreEqual("10", lista.ToString(), "El elemento agregado deber�a ser el primero.");
        }

        [TestMethod]
        //Deberia agregar elemento al final
        public void AddLast_()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.addLast(20);

            // Assert
            Assert.IsFalse(lista.IsEmpty(), "La lista no deber�a estar vac�a despu�s de agregar un elemento.");
            Assert.AreEqual(1, lista.GetSize(), "El tama�o de la lista deber�a ser 1.");
            Assert.AreEqual("20", lista.ToString(), "El elemento agregado deber�a ser el �ltimo.");
        }

        [TestMethod]
        //Deberia insertar elemento en posicion indicada
        public void InsertAt_()
        {
            // Arrange
            var lista = new listCircular();
            lista.addFirst(10);
            lista.addLast(30);

            // Act
            lista.InsertAt(20, 1);  // Inserta 20 en la posici�n 1

            // Assert
            Assert.AreEqual("10, 20, 30", lista.ToString(), "El elemento deber�a estar en la posici�n correcta.");
            Assert.AreEqual(3, lista.GetSize(), "El tama�o de la lista deber�a ser 3.");
        }

        [TestMethod]
        //Deberia eliminar el primer elemento
        public void DeleteFirst_()
        {
            // Arrange
            var lista = new listCircular();
            lista.addFirst(10);
            lista.addLast(20);

            // Act
            lista.DeleteFirst();

            // Assert
            Assert.AreEqual("20", lista.ToString(), "El primer elemento deber�a haberse eliminado.");
            Assert.AreEqual(1, lista.GetSize(), "El tama�o de la lista deber�a ser 1.");
        }

        [TestMethod]
        //Deberia eliminar ultimo elemento
        public void DeleteLast_()
        {
            // Arrange
            var lista = new listCircular();
            lista.addFirst(10);
            lista.addLast(20);

            // Act
            lista.DeleteLast();

            // Assert
            Assert.AreEqual("10", lista.ToString(), "El �ltimo elemento deber�a haberse eliminado.");
            Assert.AreEqual(1, lista.GetSize(), "El tama�o de la lista deber�a ser 1.");
        }

        [TestMethod]
        //Deberia eliminar elemento en posicion indicad
        public void DeleteAt_()
        {
            // Arrange
            var lista = new listCircular();
            lista.addFirst(10);
            lista.addLast(20);
            lista.addLast(30);

            // Act
            lista.DeleteAt(1);  // Elimina el elemento en la posici�n 1 (20)

            // Assert
            Assert.AreEqual("10, 30", lista.ToString(), "El elemento en la posici�n indicada deber�a haberse eliminado.");
            Assert.AreEqual(2, lista.GetSize(), "El tama�o de la lista deber�a ser 2.");
        }

        [TestMethod]
        //Deberia retorna el tama�oCorrecto
        public void GetSize_()
        {
            // Arrange
            var lista = new listCircular();
            lista.addFirst(10);
            lista.addLast(20);

            // Act
            int tama�o = lista.GetSize();

            // Assert
            Assert.AreEqual(2, tama�o, "El tama�o de la lista deber�a ser 2.");
        }

        [TestMethod]
        //Deberia retornar representacion correcta
        public void ToString_()
        {
            // Arrange
            var lista = new listCircular();
            lista.addFirst(10);
            lista.addLast(20);
            lista.addLast(30);

            // Act
            string resultado = lista.ToString();

            // Assert
            Assert.AreEqual("10, 20, 30", resultado, "La representaci�n en cadena deber�a ser correcta.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En lista vacia deberia lanzar excepcion
        public void DeleteFirst()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.DeleteFirst();  // Esto deber�a lanzar una excepci�n
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En lista vacia deberia lanzar excepcion
        public void DeleteLast()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.DeleteLast();  // Esto deber�a lanzar una excepci�n
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void InsertAt()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.InsertAt(10, 1);  // �ndice fuera de rango
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void DeleteAt()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.DeleteAt(0);  // �ndice fuera de rango (lista vac�a)
        }
    }
}