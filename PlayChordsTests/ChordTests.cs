using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlayChords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayChords.Tests
{
    [TestClass()]
    public class ChordTests
    {
        [TestMethod()]
        public void MajeurAkkoordTest1()
        {
            var sut = new Chord();
            Assert.AreEqual("C - E - G", sut.MajeurAkkoord("C"));
        }




        [TestMethod()]
        public void MineurAkkoordTest1()
        {
            var sut = new Chord();
            Assert.AreEqual("C - Es - G", sut.MineurAkkoord("C"));
        }


















        [DataTestMethod]
        [DataRow("C", "C - E - G")]
        [DataRow("Des", "Des - F - As")]
        [DataRow("D", "D - Ges - A")]
        [DataRow("Es", "Es - G - Bes")]
        [DataRow("As", "As - C - Es")]
        public void MajeurAkkoordTest2(string baseNote, string expected)
        {
            var sut = new Chord();
            Assert.AreEqual(expected, sut.MajeurAkkoord(baseNote));
        }



        [DataTestMethod]
        [DataRow("C", "C - Es - G")]
        [DataRow("Des", "Des - E - As")]
        [DataRow("D", "D - F - A")]
        [DataRow("Es", "Es - Ges - Bes")]
        [DataRow("As", "As - B - Es")]
        public void MineurAkkoordTest2(string baseNote, string expected)
        {
            var sut = new Chord();
            Assert.AreEqual(expected, sut.MineurAkkoord(baseNote));
        }









        [TestMethod()]
        public void GeefMajAkkoordTest()
        {
            var sut = new Chord();
            Assert.AreEqual("C - E - G - B", sut.GeefAkkoord("C", false, false, false, false, false));
        }



        [TestMethod()]
        public void GeefMinAkkoordTest()
        {
            var sut = new Chord();
            Assert.AreEqual("C - Es - G - Bes", sut.GeefAkkoord("C", true, false, false, false, false));
        }




        [TestMethod()]
        public void GeefSusAkkoordTest()
        {
            var sut = new Chord();
            Assert.AreEqual("C - E - F - B", sut.GeefAkkoord("C", false, true, false, false, false));
        }


        [TestMethod()]
        public void GeefDomAkkoordTest()
        {
            var sut = new Chord();
            Assert.AreEqual("C - E - G - Bes", sut.GeefAkkoord("C", false, false, true, false, false));
        }


        [TestMethod()]
        public void GeefVermAkkoordTest()
        {
            var sut = new Chord();
            Assert.AreEqual("C - Es - Ges - A", sut.GeefAkkoord("C", false, false, false, true, false));
        }


        [TestMethod()]
        public void GeefVermAkkoordTest2()
        {
            var sut = new Chord();
            Assert.AreEqual("C - Es - Ges - A", sut.GeefAkkoord("C", false, true, true, true, false));
        }



        [TestMethod()]
        public void GeefHalfVermAkkoordTest()
        {
            var sut = new Chord();
            Assert.AreEqual("C - Es - Ges - Bes", sut.GeefAkkoord("C", false, false, false, false, true));
        }

        [TestMethod()]
        public void GeefHalfVermAkkoordTest2()
        {
            var sut = new Chord();

            Assert.ThrowsException<ArgumentException>(() => sut.GeefAkkoord("C", false, false, true, false, true));
        }

    }
}