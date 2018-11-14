using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void ExcepcionGuardar()
        {
            Votacion v = new Votacion();
            SerializadorXML<Votacion> ser = new SerializadorXML<Votacion>();
            ser.Guardar("", v);
        }

        [TestMethod]
        [ExpectedException(typeof(ErrorArchivoException))]
        public void Eventos()
        {

        }
    }
}
