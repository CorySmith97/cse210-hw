public class csBreathing: csDisplay {

    public void csBreathingExcercise()
    {
        int csSessionTime = csGetSessionTime();
        csClearConsole();
        Console.WriteLine("Get Ready...");
        csWaitingAnimation(10);
        Console.Write("\b");
        csSkipLines();
        DateTime csStartTime = DateTime.Now;
        DateTime csFutureTime = csStartTime.AddSeconds(csSessionTime);
        DateTime csCurrentTime = DateTime.Now;
        while (csCurrentTime < csFutureTime){
            Console.Write("Breath in ... ");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }
            Console.Write("\b \n");
            Console.Write("Now breath out...");
            for (int i = 6; i >=0; i--)
            {
                Console.Write($"\b{i}");
                Thread.Sleep(1000);
            }
            Console.Write("\b \n");
            csSkipLines();
            csCurrentTime = DateTime.Now;
        }



        csWellDone(1, csSessionTime);
        Thread.Sleep(4000);
    }
}