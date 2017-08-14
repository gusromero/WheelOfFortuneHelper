using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WheelOfFortuneHelper;
using WheelOfFortuneHelper.Model;

namespace WheelOfFortuneTest
{
    [TestFixture]
    public class WordsRegExpTest
    {
        [Test]
        public void FindAWordOfFourCharacters()
        {
            var wordList = new List<string>() { "WORD", "HELLO" };
            var wf = new WordsFinder(wordList);

            var letter = new Letter();
            var word = new Word( new List<Letter>()
            {
                letter,
                letter,
                letter,
                letter
            });



            var wordsSolutions = wf.GetWords(word);

            Assert.AreEqual(1, wordsSolutions.Count);
            Assert.AreEqual("WORD", wordsSolutions[0]);
        }

        [Test]
        public void FindTwoWordsOfFourCharacters()
        {
            var wordList = new List<string>() { "WORD", "HELLO", "ABCD" };
            var wf = new WordsFinder(wordList);

            var letter = new Letter();
            var word = new Word(new List<Letter>()
            {
                letter,
                letter,
                letter,
                letter
            });

            var wordsSolutions = wf.GetWords(word);

            Assert.AreEqual(2, wordsSolutions.Count);
        }
    }
}
