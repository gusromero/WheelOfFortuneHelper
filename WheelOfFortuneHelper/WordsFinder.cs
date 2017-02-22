using System;
using System.Collections.Generic;

namespace WheelOfFortuneHelper
{
    public class WordsFinder
    {
        private List<string> _wordList;

        public WordsFinder()
        {
            _wordList = new List<string>();
        }

        public WordsFinder(List<string> wordList)
        {
            this._wordList = wordList;
        }

        public List<string> GetWords(string filter)
        {
            return _wordList;
        }
    }
}