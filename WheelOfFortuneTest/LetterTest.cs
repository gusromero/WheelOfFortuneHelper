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

        [Test]
        public void AfterDiscardingAllPossibilitesButOneLetterIsSolved()
        {
            var letter = new Letter();

            foreach (var discard in "BCDEFGHIJKJLMNOPQRSTUVWXYZ".ToCharArray())
            {
                letter.DiscardPossibility(discard);
            }


            Assert.IsTrue(letter.IsSolved);
            Assert.AreEqual('A', letter.Solution);
        }

        [Test]
        public void AfterDiscardingAllPossibilitesButTwoLetterIsNotSolved()
        {
            var letter = new Letter();

            foreach (var discard in "CDEFGHIJKJLMNOPQRSTUVWXYZ".ToCharArray())
            {
                letter.DiscardPossibility(discard);
            }

            Assert.IsFalse(letter.IsSolved);
        }


        [Test]
        public void AfterSolvingLetterIsSolved()
        {
            var letter = new Letter();

           letter.Solve('A');

            Assert.IsTrue(letter.IsSolved);
            Assert.AreEqual('A', letter.Solution);
        }


    }
}
