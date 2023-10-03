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
        "Who made me happiest today?",
        "Where did you go today? What did you do there?",
        "On a scale from 1-10, how good was your day? Explain your reasoning.",
        "Did you see the hand of the Lord today? If so, where?"};

        // Get a random prompt from the list by getting a random index.
        var random = new Random();
        int index = random.Next(promptsList.Count);
        string randomPrompt = promptsList[index];
        
        // Return the prompt to the AddEntry method.
        return randomPrompt;
    }
}