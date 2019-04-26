using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Models
{
  public class WordCounter
  {
   public static int wordsFound = 0;
   public static string userSentence;   
  }
   public static int WordFinder(string userPhrase) 
   {
     char[] userPhraseArray = userPhrase.ToString();
     foreach(char i in userPhraseArray) //(index of??//
      {
        numOfWords += 
      }
        return numOfWords;
      }


   } 