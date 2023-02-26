public class csListing: csDisplay  {
    private string[] csListingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
        private string CSGetPrompt()
    {
      
        Random randomGenerator = new Random();
        int generation = randomGenerator.Next(1,csListingPrompts.Length);
        
        string promptText = csListingPrompts[generation];

        return promptText;
    }

    public void csListingActivity(){
        int csSessionTime = csGetSessionTime();
        csClearConsole();
        string csprompt = CSGetPrompt();
        Console.WriteLine("Get Ready...");
        csSkipLines();
        Console.WriteLine("List as many response to the following prompt:");
        Console.WriteLine($" ---{csprompt}---");

        int csCounter = 0;
        DateTime csStartTime = DateTime.Now;
        DateTime csFutureTime = csStartTime.AddSeconds(csSessionTime);
        DateTime csCurrentTime = DateTime.Now;
        while (csCurrentTime < csFutureTime){
            Console.Write("> ");
            Console.Read();
            csReadEnter();
            csCounter++;
            csCurrentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {csCounter} items!");
        csWellDone(3,csSessionTime);
        Thread.Sleep(3000);
        }
}