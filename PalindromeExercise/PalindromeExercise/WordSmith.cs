using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {

        
        public bool IsAPalindrone(string word) 
        {
         
            string val = word.ToLower();

            return val.SequenceEqual(val.Reverse());

            
            
        
        }
    }
}
