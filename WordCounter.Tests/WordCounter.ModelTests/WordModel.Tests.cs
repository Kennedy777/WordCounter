using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
// using System.Web.Mvc;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class WordCounterTest
  {
      
    [TestMethod]
      public void WordCount_FindWordsinString_5()
      {  
       Assert.AreEqual(5, WordModel.CountWords("buffalo", "Buffalo buffalo buffalo Buffalo buffalo"));
       }

    [TestMethod]
       public void WordCount_FindWordsInStringWithCommas_2()
       {
       Assert.AreEqual(2, WordModel.CountWords("cats", "Some cats are good, others are not cats"));        
       }

    [TestMethod]
     public void WordCount_FindTwoWordsInStringWithCaps_2()
        {
            Assert.AreEqual(2, WordModel.CountWords("Cat", "Cat is a nice cat"));
        } 
  }
}