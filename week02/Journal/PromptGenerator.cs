using System;
using System.Collections.Generic; 
 public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "What are you grateful for today?",
        "Describe a challenge you faced and how you overcame it.",
        "What is a goal you want to achieve this week?",
        "Write about a memorable moment from your childhood."
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}