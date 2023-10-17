using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool continueLoop = true;

        //Create Scripture list made of Word objects for each word.
        List<Word> wordList = new List<Word>();
        string scripRef =  "Ether 12:27";
        string scripContent = "And if men come unto me I will show unto them their weakness." +
      " I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me;" +
      " for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        Array scripList = scripContent.Split(' ');

        foreach (string word in scripList)
        {
            Word newWord = new Word(word);
            wordList.Add(newWord);
        }

       Scripture userScripture = new Scripture(scripRef, wordList);

        //Set the basic program loop.
        do
        {
            Console.Clear();

            Console.WriteLine(userScripture.GetRenderedText());
            
            Console.WriteLine("Press Enter to continue or q to quit.");
            string input = Console.ReadLine();

            if (input == "")
            {
                if (userScripture.IsCompletelyHidden())
                {
                    continueLoop = false;
                }
                else
                {
                    userScripture.HideWords();
                }
                
            }
            else if (input.ToLower() == "q")
            {
                Console.WriteLine("Quitting...");
                continueLoop = false;
            }

        } while (continueLoop);


    }
}