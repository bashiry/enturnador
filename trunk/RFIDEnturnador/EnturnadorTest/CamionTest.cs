using EnturnadorLIB.Enturnador;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EnturnadorDAO;
using System.Collections.Generic;

namespace EnturnadorTest
{
    
    
    /// <summary>
    ///This is a test class for CamionTest and is intended
    ///to contain all CamionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CamionTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Camion Constructor
        ///</summary>
        [TestMethod()]
        public void CamionConstructorTest()
        {
            Camion target = new Camion();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Actualizar
        ///</summary>
        [TestMethod()]
        public void ActualizarTest()
        {
            Camion target = new Camion(); // TODO: Initialize to an appropriate value
            CAMION camion = null; // TODO: Initialize to an appropriate value
            int idUsuario = 0; // TODO: Initialize to an appropriate value
            target.Actualizar(camion, idUsuario);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Crear
        ///</summary>
        [TestMethod()]
        public void CrearTest()
        {
            Camion target = new Camion();
            CAMION camion = new CAMION();
            camion.activo = true;
            camion.codigoRFID = "ABCKJHKJH";
            camion.fechaModificacion = DateTime.Now;
            camion.idModificador = 1;
            camion.idTipoCargue = 1;
            camion.placa = "ABC123";
            
            int idUsuario = 1; 
            int expected = 3; 
            int actual;
            actual = target.Crear(camion, idUsuario);
            Assert.AreEqual(expected, actual);            
        }

        /// <summary>
        ///A test for Eliminar
        ///</summary>
        [TestMethod()]
        public void EliminarTest()
        {
            Camion target = new Camion(); // TODO: Initialize to an appropriate value
            int idRegistro = 2; 
            int idUsuario = 1; 
            target.Eliminar(idRegistro, idUsuario);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

    }
}
