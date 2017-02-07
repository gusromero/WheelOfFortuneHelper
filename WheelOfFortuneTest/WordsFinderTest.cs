﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WheelOfFortuneTest
{

    [TestFixture]
    public class WordsFinderTest
    {
        [Test]
        public void ReturnEmptyStringListWhenNoWordIsFound()
        {
            var wf = new WordsFinder();

            var words = wf.GetWords("");

            Assert.AreEqual(0, words.Count);
        }

        [Test]
        public void ReturnOneWordWhenThereIsOneWordInDictionary()
        {
            var wordList = new List<string>() { "word" };
            var wf = new WordsFinder(wordList);

            var words = wf.GetWords("");

            Assert.AreEqual(1, words.Count);
        }

    }
}
