using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter
{
  public class WordCount
  {
   private string _userPhrase;
   private string _keyWord;
   private int _wordCount;   
  }
   public WordFinder(string userPhrase, string keyWord, int wordCount) 
     {
         _userPhrase = userPhrase;
         _keyWord = keyWord;
         _wordCount = WordCount; 
     }

    public string FindKeyWord()
    {
        return _keyWord;
    }
    public string FindUserPhrase()
    {
        return _userPhrase;
    }   
    public int KeyWordsFound()
    {
        return _wordCount;
    }

    public static int CountWords (string keyWord, string userPhrase) 
        string[] splitUserPhrase = userPhrase.Split();
        int wordCount=0;
        foreach(var word in splitUserPhrase)
        {
            if (word.ToLower()== keyWord.ToLower())
            {
                wordCount++;
            }
        }
      return wordCount;
     }
 } 