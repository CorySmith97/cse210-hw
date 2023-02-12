using System.Linq;
public class CSRandomization{
     private string _scripture;
     Random random = new Random();
     
     //constructor
    
  
     public CSRandomization(){
        _scripture = "test";
     }
     public CSRandomization(string item){
        _scripture = item;
     }

    public void CSRemoveRandom()
        {
            bool allWordsMasked = false;
            bool csvariable1 = false;

            while (csvariable1 != true)
            {
                string[] csWords = _scripture.Split();
                int csScripLength = csWords.Length;
                int csRemovalIndex = 3;
                string[] csChangedWords = csWords.ToArray();

                allWordsMasked = csWords.All(x => x == "___");

                for (int i = 0; i < csRemovalIndex; i++)
                {
                    int csIndex = random.Next(0, csScripLength -1 );
                    while (csChangedWords[csIndex] == "___")
                    {
                        csIndex = random.Next(0, csScripLength -1 );
                    }
                    csChangedWords[csIndex] = "___";
                }

                _scripture = string.Join(" ", csChangedWords);
                
                Console.WriteLine(_scripture);
                if(!allWordsMasked)
                {
                    Console.ReadLine();
                }
                
            }
            Environment.Exit(0);
        }

}