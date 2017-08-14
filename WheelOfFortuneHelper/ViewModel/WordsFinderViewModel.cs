using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WheelOfFortuneHelper.Model;

namespace WheelOfFortuneHelper.ViewModel
{
    public class WordsFinderViewModel : ViewModelBase
    {
        private WordsReader _wordsReader;
        private WordsFinder _wordsFinder;

        private int _numberOfLetters;
        public int NumberOfLetters
        {
            get { return _numberOfLetters; }
            set
            {
                _numberOfLetters = value;
                Letters = new ObservableCollection<Letter>(new Letter[_numberOfLetters]);
            }
        }

        private ObservableCollection<Letter> _letters;

        public ObservableCollection<Letter> Letters
        {
            get { return _letters; }
            set
            {
                if (value != _letters)
                {
                    _letters = value;
                    OnPropertyChanged("Letters");
                }
            }
        }


        public WordsFinderViewModel()
        {
            _wordsReader = new WordsReader();
            var wordList = _wordsReader.GetWordList();
            _wordsFinder = new WordsFinder(wordList);
        }


    }

  
}
