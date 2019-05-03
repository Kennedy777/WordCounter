using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordModel
  {
   private string _userPhrase;
   private string _keyWord;
   private int _wordCount;   
  }
   public WordModel(string userPhrase, string keyWord, int wordCount) 
     {
         _userPhrase = userPhrase;
         _keyWord = keyWord;
         _wordCount = wordCount; 
     }

    public string FindKeyWord()
    {
        return _keyWord;
    }
    public string GetPhrase()
    {
        return _userPhrase;
    }   
    public int GetWords()
    {
        return _wordCount;
    }

    public static int CountWords (string keyWord, string userPhrase) 
    {
        string[] splitUserPhrase = userPhrase.Split(" ");
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
 } 