using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WappaMobile.ChallengeDev.Models
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void Should_Allow_Surname()
        {
            var nome = new Name("Paulo", "Duarte");
            Assert.IsTrue("Paulo Duarte".Equals(nome));
        }

        [TestMethod]
        public void Should_Allow_FullName()
        {
            var nome = new Name("Paulo Henrique", "Fernandes Duarte");
            Assert.IsTrue("Paulo Henrique Fernandes Duarte" == nome);
        }

        [TestMethod]
        public void Should_Get_FirstName()
        {
            var nome = new Name("Paulo", "Duarte");
            Assert.AreEqual("Paulo", nome.FirstName);

            var nomecompleto = new Name("Paulo Henrique Fernandes Duarte");
            Assert.AreEqual("Paulo Henrique", nomecompleto.FirstName);
        }

        [TestMethod]
        public void Should_Get_LastName()
        {
            var nome = new Name("Paulo", "Duarte");
            Assert.AreEqual("Duarte", nome.LastName);

            var nomecompleto = new Name("Paulo Henrique Fernandes Duarte");
            Assert.AreEqual("Fernandes Duarte", nomecompleto.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Deny_Empty_FirstName()
        {
            var nome = new Name("", "Duarte");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Deny_Empty_LastName()
        {
            var nome = new Name("Paulo", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Deny_Numbers()
        {
            var nome = new Name("Paulo123");
        }
    }
}
