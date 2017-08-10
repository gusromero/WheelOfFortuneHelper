﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortuneHelper
{
    public class Letter
    {
        private List<char> _posibilities;

        public char? Solution { get; private set; }

        public bool IsSolved
        {
            get { return Solution != null; }
        }

        public Letter()
        {
            _posibilities = new List<char>();
            _posibilities.AddRange("ABCDEFGHIJKLMNOPQRSTUVWXYZ");


        }

        public void DiscardPossibility(char letter)
        {
            if (_posibilities.Contains(letter))
            {
                _posibilities.Remove(letter);
            }

            if (_posibilities.Count == 1)
            {
                Solution = _posibilities[0];
            }
        }
       
    }
}
