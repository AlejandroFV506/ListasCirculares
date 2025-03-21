using ListaCircularSimple;

namespace TestListaCircularSimple
{
    [TestClass]
    public class ListaCircularTests
    {
        [TestMethod]
        //Lista deberia estar vacia
        public void ListaVacia()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            bool estaVacia = lista.ObtenerTamaño() == 0;

            // Assert
            Assert.IsTrue(estaVacia, "La lista debería estar vacía después de crearse.");
        }

        [TestMethod]
        //Deberia agregar elemento al inicio
        public void InsertarAlInicio()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.InsertarAlInicio(10);

            // Assert
            Assert.AreEqual(1, lista.ObtenerTamaño(), "El tamaño de la lista debería ser 1.");
            Assert.AreEqual("10", lista.ToString(), "El elemento debería estar al inicio.");
        }

        [TestMethod]
        //Deberia agregar elemento al final
        public void InsertarAlFinal()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.InsertarAlFinal(20);

            // Assert
            Assert.AreEqual(1, lista.ObtenerTamaño(), "El tamaño de la lista debería ser 1.");
            Assert.AreEqual("20", lista.ToString(), "El elemento debería estar al final.");
        }

        [TestMethod]
        //Deberia insertar elemento en posicion correcta
        public void InsertarEnPosicion()
        {
            // Arrange
            var lista = new ListaCircular();
            lista.InsertarAlInicio(10);
            lista.InsertarAlFinal(30);

            // Act
            lista.InsertarEnPosicion(20, 1);  // Inserta 20 en la posición 1

            // Assert
            Assert.AreEqual(3, lista.ObtenerTamaño(), "El tamaño de la lista debería ser 3.");
            Assert.AreEqual("10, 20, 30", lista.ToString(), "El elemento debería estar en la posición correcta.");
        }

        [TestMethod]
        //Deberia eliminar primer elemento
        public void EliminarAlInicio()
        {
            // Arrange
            var lista = new ListaCircular();
            lista.InsertarAlInicio(10);
            lista.InsertarAlFinal(20);

            // Act
            lista.EliminarAlInicio();

            // Assert
            Assert.AreEqual(1, lista.ObtenerTamaño(), "El tamaño de la lista debería ser 1.");
            Assert.AreEqual("20", lista.ToString(), "El primer elemento debería haberse eliminado.");
        }

        [TestMethod]
        //Deberia eliminar ultimo elemento
        public void EliminarAlFinal()
        {
            // Arrange
            var lista = new ListaCircular();
            lista.InsertarAlInicio(10);
            lista.InsertarAlFinal(20);

            // Act
            lista.EliminarAlFinal();

            // Assert
            Assert.AreEqual(1, lista.ObtenerTamaño(), "El tamaño de la lista debería ser 1.");
            Assert.AreEqual("10", lista.ToString(), "El último elemento debería haberse eliminado.");
        }

        [TestMethod]
        //Deberia eliminar elemento en posicion correcta
        public void EliminarEnPosicion()
        {
            // Arrange
            var lista = new ListaCircular();
            lista.InsertarAlInicio(10);
            lista.InsertarAlFinal(20);
            lista.InsertarAlFinal(30);

            // Act
            lista.EliminarEnPosicion(1);  // Elimina el elemento en la posición 1 (20)

            // Assert
            Assert.AreEqual(2, lista.ObtenerTamaño(), "El tamaño de la lista debería ser 2.");
            Assert.AreEqual("10, 30", lista.ToString(), "El elemento en la posición indicada debería haberse eliminado.");
        }

        [TestMethod]
        //Deberia retornar el tamaño correcto
        public void ObtenerTamaño()
        {
            // Arrange
            var lista = new ListaCircular();
            lista.InsertarAlInicio(10);
            lista.InsertarAlFinal(20);

            // Act
            int tamaño = lista.ObtenerTamaño();

            // Assert
            Assert.AreEqual(2, tamaño, "El tamaño de la lista debería ser 2.");
        }

        [TestMethod]
        //Deberia retornar representacion correcta
        public void ToString()
        {
            // Arrange
            var lista = new ListaCircular();
            lista.InsertarAlInicio(10);
            lista.InsertarAlFinal(20);
            lista.InsertarAlFinal(30);

            // Act
            string resultado = lista.ToString();

            // Assert
            Assert.AreEqual("10, 20, 30", resultado, "La representación en cadena debería ser correcta.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En la lista vacia deberia lanzar excepcion
        public void EliminarAlInicio_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.EliminarAlInicio();  // Esto debería lanzar una excepción
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En lista vacia deberia lanzar excepcion
        public void EliminarAlFinal_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.EliminarAlFinal();  // Esto debería lanzar una excepción
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void InsertarEnPosicion_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.InsertarEnPosicion(10, 1);  // Índice fuera de rango
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void EliminarEnPosicion_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.EliminarEnPosicion(0);  // Índice fuera de rango (lista vacía)
        }
    }
}