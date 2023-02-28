public class csDisplay {

    protected int csGetSessionTime(){
        csSkipLines();
        Console.WriteLine("How long, in seconds, would you like your session to be? ");
        return int.Parse(Console.ReadLine());
   
    }

    public int csMainMenu(){
        csClearConsole();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflection activity");
        Console.WriteLine(" 3. Start listening activity");
        Console.WriteLine(" 4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int userChoice = int.Parse(Console.ReadLine());
        return userChoice;
    }

    public void csWelomeMenu(int choice){
        if (choice == 1 ){
            Console.WriteLine("Welcome to the Breathing Activity");
            csSkipLines();
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");
            Console.WriteLine("Clear your mind and focus on your breathing.");
            
        } else if (choice == 2){
            Console.WriteLine("Welcome to the Reflection Activity");
            csSkipLines();
            Console.WriteLine("This activity will help you reflect on times in your life when you ahve shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
        } else if (choice == 3){
            Console.WriteLine("Welcome to the Listening Activity");
            csSkipLines();
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            
        }
        return;

    }

    protected void csWaitingAnimation(int csTime)
{   
        List<char> spins = new List<char>{ '|', '/', '-', '\\'} ;
        while(csTime >0)
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(100);
                Console.Write($"\b{spins[i]}");
                csTime--;
            }
        }
        Console.WriteLine("\b \n");
}
    protected void csClearConsole(){
        Console.Clear();
    }

    protected void csSkipLines(){
        Console.WriteLine();
        Console.WriteLine();
    }
    protected void csReadEnter(){
        Console.ReadLine();
    }
    protected void csWellDone(int choice, int sessionTime){
        csSkipLines();
        Console.Write("Well Done!");
        csWaitingAnimation(20);
        Thread.Sleep(2000);
        csSkipLines();
        if (choice == 1){
            Console.WriteLine($"You have completed another {sessionTime} seconds of the Breathing Activity");
        } else if (choice == 2){
            Console.WriteLine($"You have completed another {sessionTime} seconds of the Reflection Activity");
        } else if (choice == 3){
            Console.WriteLine($"You have completed another {sessionTime} seconds of the Listing Activity");
        }

    }
    
    
}