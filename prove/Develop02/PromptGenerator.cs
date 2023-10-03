using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public PromptGenerator()
    {
    }

    public string GeneratePrompt()
    {
        // Create a string of possible prompts.
        List<string> promptsList = new List<string>{"What was one good thing that happened today?", 
        "If I had one thing I could do over today, what would it be?", 
        "Who made me happiest today?"};

        // Get a random prompt from the list by getting a random index.
        var random = new Random();
        int index = random.Next(promptsList.Count);
        string randomPrompt = promptsList[index];
        
        // Return the prompt to the AddEntry method.
        return randomPrompt;
    }
}