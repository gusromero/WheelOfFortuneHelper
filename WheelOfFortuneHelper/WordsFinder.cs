using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            if (string.IsNullOrEmpty(filter))
                return _wordList;
            return _wordList.FindAll(p=> p.Equals(filter));
        }

        public List<string> GetWords(Word filter)
        {
            var pattern = filter.ToRegExp();

            var result = new List<string>();

            foreach (var word in _wordList)
            {
                if (Regex.IsMatch(word, pattern))
                    result.Add(word);
            }
            return result;
            // return _wordList.Where(word => Regex.IsMatch(word, pattern)).ToList();

        }
    }
}