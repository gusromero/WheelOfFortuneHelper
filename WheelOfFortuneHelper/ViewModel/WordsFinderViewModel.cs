using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortuneHelper.ViewModel
{
    public class WordsFinderViewModel
    {
        private WordsReader _wordsReader;
        private WordsFinder _wordsFinder;

        private List<LetterViewModel> _letters;

        public WordsFinderViewModel()
        {
            _wordsReader = new WordsReader();
            var wordList = _wordsReader.GetWordList();
            _wordsFinder = new WordsFinder(wordList);
        }


    }

  
}
