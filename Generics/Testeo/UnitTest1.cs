using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Testeo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //MiLista<int> a = null;
            MiLista<int> a = new MiLista<int>();

            try
            {
                a.Add(3);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.GetType() == typeof(Exception));
            }

            //Assert.IsNull(a);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MiLista<int> lista = new MiLista<int>();
            lista.Add(4);
            lista.Add(40);

            Assert.IsTrue(lista.Count == 2);

            int i = 0;
            foreach (int item in lista)
            {
                Assert.AreEqual(item, lista[i]);
                i++;
            }

            MiLista<string> listad = new MiLista<string>();
            listad.Add("4");
            listad.Add("40");

            Assert.IsTrue(listad.Count == 2);

        }

    }
}
