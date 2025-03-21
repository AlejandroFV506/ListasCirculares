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
            bool estaVacia = lista.ObtenerTama�o() == 0;

            // Assert
            Assert.IsTrue(estaVacia, "La lista deber�a estar vac�a despu�s de crearse.");
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
            Assert.AreEqual(1, lista.ObtenerTama�o(), "El tama�o de la lista deber�a ser 1.");
            Assert.AreEqual("10", lista.ToString(), "El elemento deber�a estar al inicio.");
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
            Assert.AreEqual(1, lista.ObtenerTama�o(), "El tama�o de la lista deber�a ser 1.");
            Assert.AreEqual("20", lista.ToString(), "El elemento deber�a estar al final.");
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
            lista.InsertarEnPosicion(20, 1);  // Inserta 20 en la posici�n 1

            // Assert
            Assert.AreEqual(3, lista.ObtenerTama�o(), "El tama�o de la lista deber�a ser 3.");
            Assert.AreEqual("10, 20, 30", lista.ToString(), "El elemento deber�a estar en la posici�n correcta.");
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
            Assert.AreEqual(1, lista.ObtenerTama�o(), "El tama�o de la lista deber�a ser 1.");
            Assert.AreEqual("20", lista.ToString(), "El primer elemento deber�a haberse eliminado.");
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
            Assert.AreEqual(1, lista.ObtenerTama�o(), "El tama�o de la lista deber�a ser 1.");
            Assert.AreEqual("10", lista.ToString(), "El �ltimo elemento deber�a haberse eliminado.");
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
            lista.EliminarEnPosicion(1);  // Elimina el elemento en la posici�n 1 (20)

            // Assert
            Assert.AreEqual(2, lista.ObtenerTama�o(), "El tama�o de la lista deber�a ser 2.");
            Assert.AreEqual("10, 30", lista.ToString(), "El elemento en la posici�n indicada deber�a haberse eliminado.");
        }

        [TestMethod]
        //Deberia retornar el tama�o correcto
        public void ObtenerTama�o()
        {
            // Arrange
            var lista = new ListaCircular();
            lista.InsertarAlInicio(10);
            lista.InsertarAlFinal(20);

            // Act
            int tama�o = lista.ObtenerTama�o();

            // Assert
            Assert.AreEqual(2, tama�o, "El tama�o de la lista deber�a ser 2.");
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
            Assert.AreEqual("10, 20, 30", resultado, "La representaci�n en cadena deber�a ser correcta.");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En la lista vacia deberia lanzar excepcion
        public void EliminarAlInicio_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.EliminarAlInicio();  // Esto deber�a lanzar una excepci�n
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //En lista vacia deberia lanzar excepcion
        public void EliminarAlFinal_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.EliminarAlFinal();  // Esto deber�a lanzar una excepci�n
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void InsertarEnPosicion_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.InsertarEnPosicion(10, 1);  // �ndice fuera de rango
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        //Indice fuera de rango deberia lanzar excepcion
        public void EliminarEnPosicion_()
        {
            // Arrange
            var lista = new ListaCircular();

            // Act
            lista.EliminarEnPosicion(0);  // �ndice fuera de rango (lista vac�a)
        }
    }
}