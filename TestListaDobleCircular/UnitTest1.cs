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
            Assert.IsTrue(estaVacia, "Una lista nueva debería estar vacía.");
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
            Assert.IsFalse(lista.IsEmpty(), "La lista no debería estar vacía después de agregar un elemento.");
            Assert.AreEqual(1, lista.GetSize(), "El tamaño de la lista debería ser 1.");
            Assert.AreEqual("10", lista.ToString(), "El elemento agregado debería ser el primero.");
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
            Assert.IsFalse(lista.IsEmpty(), "La lista no debería estar vacía después de agregar un elemento.");
            Assert.AreEqual(1, lista.GetSize(), "El tamaño de la lista debería ser 1.");
            Assert.AreEqual("20", lista.ToString(), "El elemento agregado debería ser el último.");
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
            lista.InsertAt(20, 1);  // Inserta 20 en la posición 1

            // Assert
            Assert.AreEqual("10, 20, 30", lista.ToString(), "El elemento debería estar en la posición correcta.");
            Assert.AreEqual(3, lista.GetSize(), "El tamaño de la lista debería ser 3.");
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
            Assert.AreEqual("20", lista.ToString(), "El primer elemento debería haberse eliminado.");
            Assert.AreEqual(1, lista.GetSize(), "El tamaño de la lista debería ser 1.");
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
            Assert.AreEqual("10", lista.ToString(), "El último elemento debería haberse eliminado.");
            Assert.AreEqual(1, lista.GetSize(), "El tamaño de la lista debería ser 1.");
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
            lista.DeleteAt(1);  // Elimina el elemento en la posición 1 (20)

            // Assert
            Assert.AreEqual("10, 30", lista.ToString(), "El elemento en la posición indicada debería haberse eliminado.");
            Assert.AreEqual(2, lista.GetSize(), "El tamaño de la lista debería ser 2.");
        }

        [TestMethod]
        //Deberia retorna el tamañoCorrecto
        public void GetSize_()
        {
            // Arrange
            var lista = new listCircular();
            lista.addFirst(10);
            lista.addLast(20);

            // Act
            int tamaño = lista.GetSize();

            // Assert
            Assert.AreEqual(2, tamaño, "El tamaño de la lista debería ser 2.");
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
            Assert.AreEqual("10, 20, 30", resultado, "La representación en cadena debería ser correcta.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En lista vacia deberia lanzar excepcion
        public void DeleteFirst()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.DeleteFirst();  // Esto debería lanzar una excepción
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En lista vacia deberia lanzar excepcion
        public void DeleteLast()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.DeleteLast();  // Esto debería lanzar una excepción
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void InsertAt()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.InsertAt(10, 1);  // Índice fuera de rango
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void DeleteAt()
        {
            // Arrange
            var lista = new listCircular();

            // Act
            lista.DeleteAt(0);  // Índice fuera de rango (lista vacía)
        }
    }
}