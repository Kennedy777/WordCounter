// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using WordCounter;

// namespace WordCounter.Controllers
// {
//    public class WordController : Controller 
//    {
//      [HttpPost("/checkword")]
//      public ActionResult CheckWord()
//         {
//             string keyWord = Request.Form["word"];
//             string userPhrase = Request.Form["phrase"];
//             int count = WordModel.CountWords(keyWord, userPhrase);

//             WordModel Model = new WordModel(keyWord, userPhrase, wordCount);

//             return View(Model);
//         }
//    }
// }
