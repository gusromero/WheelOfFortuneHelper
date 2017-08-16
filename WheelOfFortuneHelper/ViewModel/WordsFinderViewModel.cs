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
                Letters = InitializeLetters(_numberOfLetters);
            }
        }

        private ObservableCollection<LetterViewModel> InitializeLetters(int numberOfLetters)
        {
            var collection = new ObservableCollection<LetterViewModel>();
            for (var i = 0; i < numberOfLetters; i++)
            {
                collection.Add(new LetterViewModel());
            }

            return collection;
        }

        private ObservableCollection<LetterViewModel> _letters;
        public ObservableCollection<LetterViewModel> Letters
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

        private string _discardedLetters;

        public string DiscardedLetters
        {
            get { return _discardedLetters; }
            set
            {
                if (value != _discardedLetters)
                {
                    _discardedLetters = value;
                    DiscardLetters();
                }
            }
        }

        private  void DiscardLetters()
        {
            foreach (var discardedLetter in _discardedLetters.ToCharArray())
            {
                foreach (var letter in Letters)
                {
                    letter.DiscardPossibility(discardedLetter);   
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
