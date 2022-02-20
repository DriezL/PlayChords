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
        [DataTestMethod]
        [DataRow("C", "C - E - G")]
        [DataRow("Des", "Des - F - As")]
        [DataRow("D", "D - Ges - A")]
        [DataRow("Es", "Es - G - Bes")]
        [DataRow("As", "As - C - Es")]
        public void MajeurAkkoordTest(string note, string verwacht)
        {
            var sut = new Chord();
            Assert.AreEqual(verwacht, sut.MajeurAkkoord(note));
        }

        [DataTestMethod]
        [DataRow("C", "C - Es - G")]
        [DataRow("Des", "Des - E - As")]
        [DataRow("D", "D - F - A")]
        [DataRow("Es", "Es - Ges - Bes")]
        [DataRow("As", "As - B - Es")]
        public void MineurAkkoordTest(string note, string verwacht)
        {
            var sut = new Chord();
            Assert.AreEqual(verwacht, sut.MineurAkkoord(note));
        }

    }
}