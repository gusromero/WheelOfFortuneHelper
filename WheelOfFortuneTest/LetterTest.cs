using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WheelOfFortuneHelper;

namespace WheelOfFortuneTest
{
    [TestFixture]
    public class LetterTest
    {
        [Test]
        public void NewLetterIsNotSolved()
        {
            var letter = new Letter();
            Assert.IsFalse(letter.IsSolved);
        }

    }
}
