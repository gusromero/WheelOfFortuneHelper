using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelOfFortuneHelper.Model;

namespace WheelOfFortuneHelper.ViewModel
{
    public class LetterViewModel : ViewModelBase
    {
        private Letter _letter;

        public LetterViewModel()
        {
            _letter = new Letter();
        }

        public char Solution
        {
            get { return _letter.Solution ?? '\0'; }

            set
            {
                _letter.Solve(value);
            }
        }

        public void DiscardPossibility(char discardedLetter)
        {
            _letter.DiscardPossibility(discardedLetter);
            OnPropertyChanged("Solution");
        }
    }
}
