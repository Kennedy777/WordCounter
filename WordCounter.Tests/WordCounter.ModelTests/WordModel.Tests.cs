using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class WordCounterTest
  {
      
    [TestMethod]
    public void WordCount_FindWordsinString_5()
    {  
       Assert.AreEqual(5, WordCounter.CountWords("buffalo", "Buffalo buffalo buffalo Buffalo buffalo."));
    }

    [TestMethod]
    public void WordCount_FindWordsInStringWithCommas_2()
    {
       Assert.AreEqual(2, WordCounter.CountWords("cats", "Some cats are good, others are not cats.");        )
    }
  }
}