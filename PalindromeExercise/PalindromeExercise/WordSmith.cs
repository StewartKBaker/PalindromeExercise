using System;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        char[] wordArray = word.ToCharArray();
        Array.Reverse(wordArray);
        string reversed = new string(wordArray);

        return reversed.ToLower() == word.ToLower();
    }
}