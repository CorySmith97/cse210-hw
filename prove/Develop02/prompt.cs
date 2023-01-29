public class CSPrompt {
   
   public string[] prompts = {
    "How have you seen the hand of the Lord in your life?",
    "What was the best part of your day?",
    "Who is the person who has had the biggest impact on you?",
    "What is pushing you forward in life?",
    "Who is your biggest inspiration?",
    "Who was the most interesting person I interacted with today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
   };
   

    public string CSGetPrompt()
    {
      
        Random randomGenerator = new Random();
        int generation = randomGenerator.Next(1,prompts.Length);
        
        string promptText = prompts[generation];

        return promptText;
    }
}