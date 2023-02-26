public class csReflection: csDisplay  {

    private string[] csPrompts = {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
   };
   private string[] csFollowUpQuestions = {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
   };
   
   private string csGetFollowUpQuestion(){
    Random randomGenerator = new Random();
    int generation = randomGenerator.Next(1,csFollowUpQuestions.Length);
    string csQuestionText = csFollowUpQuestions[generation];
    return csQuestionText;
   }

    private string CSGetPrompt()
    {
      
        Random randomGenerator = new Random();
        int generation = randomGenerator.Next(1,csPrompts.Length);
        
        string promptText = csPrompts[generation];

        return promptText;
    }
    public void csReflectionActivity(){
        int csSessionTime = csGetSessionTime();
        csClearConsole();
        Console.WriteLine("Get Ready...");
        string prompt = CSGetPrompt();
        csSkipLines();
        Console.WriteLine("Consider the following prompt");
        csSkipLines();
        Console.WriteLine($" --- {prompt} ---");
        csSkipLines();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        csReadEnter();
        csSkipLines();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in  ");
        for (int i =5; i >0; i--){
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        csClearConsole();
        
        DateTime csStartTime = DateTime.Now;
        DateTime csFutureTime = csStartTime.AddSeconds(csSessionTime);
        DateTime csCurrentTime = DateTime.Now;
        while (csCurrentTime < csFutureTime){
            string csFollowUp = csGetFollowUpQuestion();
            Console.Write($" > {csFollowUp} ");
            csWaitingAnimation(25);
            Thread.Sleep(2500);
            csCurrentTime = DateTime.Now;
        }
        csWellDone(2, csSessionTime);
        Thread.Sleep(3000);
        
    }
}