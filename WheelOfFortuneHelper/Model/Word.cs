using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortuneHelper.Model
{


    public class Word : IRegExpressionable
    {
        private List<Letter> _letters;

        public Word()
        :this(new List<Letter>())
        {
            
        }

        public Word(List<Letter> letters)
        {
            _letters = letters;
        }

        public string ToRegExp()
        {
            return "^" + _letters.Aggregate(string.Empty, (current, letter) => current + letter.ToRegExp()) +"$";
        }
    }
}
