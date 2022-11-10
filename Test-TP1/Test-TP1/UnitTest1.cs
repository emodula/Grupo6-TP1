

using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Specialized;
using static Grupo6TP1.Program;

namespace Test_TP1
{
    [TestClass]
    public class UnitTest1
    {
        // Ejercicios de Generalidades
        
        //Ejercicio 1
        [TestMethod]
        public void TestSuma()
        {
            //Dados
            int num1 = 1;
            int num2 = 2;
            int esperado = 3;

            //Cuando
            int calculado = Grupo6TP1.Program.Suma(num1, num2);
            Assert.AreEqual(esperado, calculado);
        }

        //Ejercicio 2

        [TestMethod]
        public void TestCortarString()
        {
            string cadena = "Egresados";
            string esperado = "Egre";
            string cadenaCortada = Grupo6TP1.Program.CortarString(cadena);
            Assert.AreEqual(cadenaCortada, esperado);

        }

        //Ejercicio 3

        [TestMethod]
        public void TestFechaHoraActual()
        {

            DateTime fecha = DateTime.Now;
            string impFecha = "";
            string fechaEperada = fecha.ToString(impFecha);
            string fechaRecibida = Grupo6TP1.Program.FechaHoraActual();
            Assert.AreEqual(fechaEperada, fechaRecibida);

        }

        //Enumeraciones

        //Ejercicio 1 y 2

        [TestMethod]     
        public void TestTextoDia()
        { 
            int num = 1;
            string dia = "Lunes";
            DiasSemana diaEsperado = (DiasSemana)Enum.Parse(typeof(DiasSemana), dia);
            Assert.AreEqual(diaEsperado, Grupo6TP1.Program.TextoDia(num));
        }

        //Conversiones

        // Ejercicio 1

        [TestMethod]
        public void TestConvertirANum()
        {
            bool value = true;
            int esperado = 1;
            int result = Grupo6TP1.Program.ConvertirANum1(value);
            Assert.AreEqual(esperado,result);
        }

        //Ejercicio 3

        [TestMethod]
        public void TestEnumColor()
        {
            int value = 1;
            string colorEsperado = "Azul";
            string  result = Grupo6TP1.Program.EnumColor(value);
            Assert.AreEqual(colorEsperado, result);
        }

        //Ejercicio 4


        [TestMethod]
        public void TestEvalNum()
        {
            int num= 15;
            string mensaje = "mayor a 10";
            string result = Grupo6TP1.Program.EvalNum(num);
            Assert.AreEqual(mensaje, result);

        }

        // Ejercicio 7
        [TestMethod]
        public void TestHasta50()
        {
            int numEsperado = 50;
            int result = Grupo6TP1.Program.Hasta50();
            Assert.AreEqual(numEsperado, result);

        }

    }
}