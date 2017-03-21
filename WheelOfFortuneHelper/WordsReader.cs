using System;
using System.Collections.Generic;
using System.IO;


namespace WheelOfFortuneHelper
{
    public class WordsReader
    {
       private string _filename = string.Format("{0}/Resources/words.txt", AppDomain.CurrentDomain.BaseDirectory);

        public List<string> GetWordList()
        {
            var list = new List<string>();
            using (StreamReader sr = new StreamReader(_filename))
            {
                while (sr.Peek() >= 0)
                {
                    string line = sr.ReadLine();
                    string[] words = line.Split();
                    list.AddRange(words);
                }
            }
            return list;
        }
    }
}
