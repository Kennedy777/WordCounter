using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Solution;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void TestWordFinderFunction()
    {  
       
      string userInput = "Scrabble";
      int testScore = 14;
      Assert.AreEqual(testScore, Scrabble.ScrabbleCalc(userInput));

    }


  }
}