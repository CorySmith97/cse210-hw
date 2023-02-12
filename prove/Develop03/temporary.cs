public class CSDisplay
{
    private string csMenu = "Welcome to the memorization app. Press enter to begin";

    public void csDisplayMenu()
    {
        Console.WriteLine(csMenu);
    }


    public void CSWaitForEnter()
    {
        Console.ReadLine();
    }

}