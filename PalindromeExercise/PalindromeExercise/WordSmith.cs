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
            return s.ToUpper().SequenceEqual(s.ToUpper().Reverse());       
            //var original = s.ToUpper();
            //var reversed = new string(original.Reverse().ToArray());
            //var palindrom = original == reversed;
            //return palindrom;
            //var back = "";                             //another method to reverse the word and check it.
            //for (int i = s.Length - 1; i >=0; i--)
            //{
            //    back += s.ToLower()[i];
            //}
            //if (back == s.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
