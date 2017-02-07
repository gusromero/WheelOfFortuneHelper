using System;
using System.Collections.Generic;

namespace WheelOfFortuneTest
{
    public class WordsFinder
    {
        private List<string> _wordList;

        public WordsFinder()
        {
        }

        public WordsFinder(List<string> wordList)
        {
            this._wordList = wordList;
        }

        public List<string> GetWords(string v)
        {
            return _wordList;
        }
    }
}