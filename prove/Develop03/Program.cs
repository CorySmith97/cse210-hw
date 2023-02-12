using System;
using System.IO;
using System.Linq;
//cory smith
//https://www.w3schools.com/cs/cs_for_loop.php
//https://josipmisko.com/posts/c-sharp-string-length
//https://stackoverflow.com/questions/692323/when-should-one-use-environment-exit-to-terminate-a-console-application

class Program
{
    static void Main(string[] args)
    {

        
        CSScriptures scrip = new CSScriptures("Proverbs 3: 5-6"," 5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.");
        CSDisplay csdis = new CSDisplay();
        CSRandomization csran = new CSRandomization("5 Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.");

        csdis.csDisplayMenu();
        csdis.CSWaitForEnter();
        scrip.csPrintTitle();
        csran.CSRemoveRandom();
        Console.WriteLine("Good job!");
          
    }
}