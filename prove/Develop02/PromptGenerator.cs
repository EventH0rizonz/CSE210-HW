public class PromptGenerator
{
    List<string> _prompts = new List<string>() {
        "Did I experiance anyting new today?",
        "Did I not acomplish somthing I wanted to today?",
        "Is there anything you would want to remember from today?",
        "What was the best part of my day?",
        "What was the worst part of my day",
        "What three changes can you make to live according to your personal values?",
        "Did I grow spiritually today?",
        "Did I make any plans today?",
        "Are you gratefull for anything?",
        "How does work fulfill you? Does it leave you wanting more?",
    };

    public string WritePrompt()
    {  
        Random randomgenerator = new Random();
        int randomNumber = randomgenerator.Next(0, _prompts.Count());

        return _prompts[randomNumber];
    }
}