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
       
      string userPhrase = "Buffalo buffalo buffalo Buffalo buffalo.";
      int wordsFound = 5;
      Assert.AreEqual(wordsFound, WordCounter.WordFinder(userPhrase));

    }


  }
}