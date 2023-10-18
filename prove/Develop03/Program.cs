using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //Create scripture and reference variables to pull from.
        string scripRef =  "Ether 12:27";
        string scripContent = "And if men come unto me I will show unto them their weakness." +
      " I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me;" +
      " for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        
        //Create Scripture List
        List<Word> wordList = new List<Word>();
        Array scripList = scripContent.Split(' ');
        foreach (string word in scripList)
        {
            Word newWord = new Word(word);
            wordList.Add(newWord);
        }

        //Create Reference
        var referenceList = scripRef.Split(' ', ':', '-');
        Reference userReference = new Reference(referenceList[0], referenceList[1], referenceList[2]);

        // Create Scripture object.
        Scripture userScripture = new Scripture(userReference.CreateReference(), wordList);



        //Set the basic program loop.
        bool continueLoop = true;
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