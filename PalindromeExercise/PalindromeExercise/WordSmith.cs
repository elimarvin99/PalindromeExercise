using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        { 
        }
        public bool IsPalindrome(string s)
        {
            return s.SequenceEqual(s.Reverse());
            //var original = s;
            //var reversed = new string(original.Reverse().ToArray());
            //var palindrom = original == reversed;
        }
    }
}
