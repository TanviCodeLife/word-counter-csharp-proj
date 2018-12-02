# _Word Counter Project_
#### Week 1 CSharp Independent Project at Epicodus, 10.16.2018

### Created By
* _Tanvi Garg_

### Description
* _This C# application gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only._


### Specifications
* _**Takes in a user input letter and outputs a letter**_
* _Input: "C"_
* _Output: "C"_
* _**Takes in a user input word and outputs a word**_
* _Input: "Cat"_
* _Output: "Cat"_
* _**Takes in a user input letter and a word in two different variables. Returns those correctly**_
* _Input1: "C"_
* _Input2: "Cat"_
* _Output1: "C"_
* _Output2: "Cat"_
* _**Takes in a user input word and a sentence in two different variables using the setter methods. Returns those correctly**_
* _Input1: "Cat"_
* _Input2: "This is a Cat"_
* _Output1: "Cat"_
* _Output2: "This is a Cat"_
* _**Check if input word i.e Input2 contains the input letter i.e. Input1 using loop and increment count**_
* _Input1: "C"_
* _Input2: "Cat"_
* _Output: 1_
* _**Check if input word i.e Input2 contains the input letter i.e. Input1 using loop and increment count when upper and lower case letters are present**_
* _Input1: "C"_
* _Input2: "CatAN"_
* _Output: 1_
* _**Converts the sentence ie. Input2 and splits it into either a List or an Array of strings.**_
* _Input1: "cat"
* _Input2: "this is a cat"_
* _Output2: {"this", "is", "a", "cat"}_
* _**Compare and checks whether Input1 is contained in Input2**_
* _Input1: "cat"
* _Input2: this is a cat_
* _Output: True_
* _**Takes in input1 and input2 and compares for multiple occurences of input1 in input2 using a loop. Output is the count of occurences**_
* _Input1: "cat"_
* _Input2: "this is a black cat with a white cat"_
* _Output: 2_
* _**Takes in mixed case inputs and compares for multiple occurences of input1 in input2 using a loop. Output is the count of occurences**_
* _Input1: "cat"_
* _Input2: "this is a black CAt with a White cat"_
* _Output: 2_
* _**Takes in mixed case inputs and compares for multiple occurences of input1 in input2 while ignoring words that might be superset of the input1 like "cat" in "cat"hedral using a loop. Output is the count of occurences**_
* _Input1: "cat"_
* _Input2: "this is a black CAt with a White cat in a cathedral"_
* _Output: 2_
* _**Add functionality to remove special characters and split a sentence into an array/list**_
* _Input: "I'm in a cathedral"_
* _Output: "I m in a cathedral"_

### Complete setup/installation instructions
1. _Go to GitHub profile and project @ [TanviCodeLife](https://github.com/TanviCodeLife/word-counter-csharp-proj)_
2. _Use #git clone <project url> command to pull it to a local repository in your Home directory using a bash terminal._
3. _Go to project folder and cd into word-counter-csharp-proj/WordCounter directory from your bash terminal_
4. _run #dotnet run_
5. _Wait till you see this message display in you bash terminal - "Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down."_
6. _Copy the local host link you see in the message for eg http://localhost:5000 and paste it into your web browser address bar._
7. _Browse through the project._

### Technologies used
1. **CSharp**
2. **DotNet Core Framework**
3. **MSTest BDD Workflow**
3. **Atom**
4. **Command Line**
5. **GitHub**

### Known Bugs
_No known bugs._

### Contact information
_tanvi.garg23@gmail.com_

### Support
* _For issues, please contact authors at the provided contact information above._

MIT License
