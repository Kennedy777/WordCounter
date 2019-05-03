# Word Counter

#### A C-sharp program: Two-Part Independent Project

#### By **Marguerite Kennedy, revised May 3, 2019**

## Description

This is the first stage in a two-stage project to create a "word counter" program, as the first independent project for the first two weeks of the Epicodus C# curriculum. 

The program will prompt the user for a "search word" AND, separately, a sentence or phrase. It will then check to see how often the initial word appears in the sentence. This only applies to words *in their entirety,* so letters of a word embedded in other words (e.g., if the user's search word is "car," "carpet" will not be counted).

The initial (4/26/19) phase will invovle creating tests and building out initial game logic. 

For the second (5/3/19) phase, MVC logic is built out, creating a splash page that allows the user to navigae to the "Word Counter" game.

## Specs 

Initial tests will determine how many times a word, in its integrality (i.e., not a within a longer word), appear in a phrase. 

Let's say a user's search word is "buffalo," and their sentence is, "Buffalo buffalo buffalo Buffalo buffalo" (fun fact: that is the longest sentence using only one word, albeit with differnet meanings in each instance, in the English language!).

With this input, we'd expect that the the program will find five (5) instances of the word, and output that to the user. The first test will be designed to "successfully fail" by submitting a test argument that is a word NOT appearing in the test string. 

In the second phase of buildout, MVC and user interface added using CSS (Bootstrap and original CSS stylesheet) and JavaScript. 

## Setup/Installation Requirements

The repositiory for this project can be found at : https://github.com/Kennedy777/WordCounter

This phase is not on Github pages since there's no user interface yet. 

## Known Bugs
* None currently known. 

## Technologies Used (in initial phase)
  * C# 
  * .NET framework
  * MSTest

## Support and contact details

_Email me at reach.marguerite@gmail.com with any questions, comments, or concerns._

### License

*This software is licensed under the MIT license*

Copyright (c) 2019 Marguerite Kennedy
