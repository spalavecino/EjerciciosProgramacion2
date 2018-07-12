using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaAbstract;
using System.Collections.Generic;
using Franja = CentralitaAbstract.Provincial.Franja;

namespace CentralitaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListCall_Instantiated()
        {
            Centralita centralita;

            centralita = new Centralita();

            Assert.IsNotNull(centralita.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaException_Throwed_When_Same_LocalCall()
        {
            // Arrange
            var centralita = new Centralita();
            var llamadaLocal = new Local("origen 1", (float)15.2, "destino 1", (float)169.5);
            var llamadaLocal2 = new Local("origen 1", (float)10.2, "destino 1", (float)69.5);
            // Act
            centralita = centralita + llamadaLocal;
            centralita = centralita + llamadaLocal2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaException_Throwed_When_Same_ProvincialCall()
        {
            // Arrange
            var centralita = new Centralita();
            var llamadaProvincial = new Provincial("origen 1", Franja.Franja_1, (float)12.2, "destino 1");
            var llamadaProvincial2 = new Provincial("origen 1", Franja.Franja_2, (float)25.2, "destino 1");

            // Act
            centralita = centralita + llamadaProvincial;
            centralita = centralita + llamadaProvincial2;
        }

        [TestMethod]
        public void Comparision_Local_And_Provincial_calls()
        {
            var llamadaLocal = new Local("origen 1", (float)15.2, "destino 1", (float)169.5);
            var llamadaLocal2 = new Local("origen 1", (float)10.2, "destino 1", (float)69.5);
            var llamadaProvincial = new Provincial("origen 1", Franja.Franja_1, (float)12.2, "destino 1");
            var llamadaProvincial2 = new Provincial("origen 1", Franja.Franja_2, (float)25.2, "destino 1");

            Assert.IsTrue(llamadaLocal == llamadaLocal2);
            Assert.IsTrue(llamadaProvincial == llamadaProvincial2);
            Assert.IsFalse(llamadaLocal == llamadaProvincial);
            Assert.IsFalse(llamadaLocal2 == llamadaProvincial2);
            Assert.IsFalse(llamadaLocal2 == llamadaProvincial);
            Assert.IsFalse(llamadaLocal == llamadaProvincial2);
        }
    }
}
