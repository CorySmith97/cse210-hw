using System;
using System.IO;
// Cory Smith Jan 12 2023
// sources: https://www.w3schools.com/cs/cs_arrays.php
// https://stackoverflow.com/questions/35290369/clear-object-variables
// Brother Clements was a good resource for bug fixing
//https://www.dotnetperls.com/split
class Program
{

    static void Main(string[] args)
    {
        int CSchoice = CSDisplayMenu();
        CSPrompt CSprompts = new CSPrompt();
        CSData CSdataStorage = new CSData();
        CSEntries CSentry = new CSEntries();
        

        DateTime theCurrentTime = DateTime.Now;
        string csdateTime = theCurrentTime.ToShortDateString();
        
        
        while (CSchoice != 5)
        {
            

            if (CSchoice == 1)
            {
            CSentry = new CSEntries();
            CSentry._dataTime = csdateTime;

            string CSpromptText = CSprompts.CSGetPrompt();
            CSentry._promptText = CSpromptText;

            Console.WriteLine(CSpromptText);
            Console.Write(">");
            CSentry._userEntry = Console.ReadLine();
            CSdataStorage.add(CSentry);

            
            
            CSchoice = CSDisplayMenu();

            }
            else if (CSchoice == 2)
            {
                CSdataStorage.CSDisplayData();

                CSchoice = CSDisplayMenu();
                
            }
            else if (CSchoice == 3)
            {
                Console.Write("What is the name of the file you wish to open? ");
                string userInput = Console.ReadLine();
                CSdataStorage._fileName = userInput;

                CSdataStorage.CSReadFile();

                CSchoice = CSDisplayMenu();
            }
            else if (CSchoice == 4)
            {
                Console.Write("What would you like to name the file?");
                CSdataStorage._fileName = Console.ReadLine(); 
                CSdataStorage.CSWriteDataToFile();

                CSchoice = CSDisplayMenu();
            }
    
        }
        static int CSDisplayMenu()
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");
            int CSchoice = int.Parse(Console.ReadLine());
            return CSchoice;
        }
    }
}