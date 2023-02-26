using System;

//Cory Smith 02/25/2022
// https://learn.microsoft.com/en-us/dotnet/api/system.console.clear?view=net-5.0
//https://www.w3schools.com/cs/cs_switch.php


class Program
{
    static void Main(string[] args)
    {
        csDisplay displayControl = new csDisplay();
        csBreathing csBreath = new csBreathing();
        csReflection csReflect = new csReflection();
        csListing csList = new csListing();

        int csChoice = displayControl.csMainMenu();
        displayControl.csWelomeMenu(csChoice);
        while (csChoice != 4){
            if (csChoice == 1){
                csBreath.csBreathingExcercise();
                csChoice = displayControl.csMainMenu();
            } else if (csChoice == 2){
                csReflect.csReflectionActivity();
                csChoice = displayControl.csMainMenu();
            } else if (csChoice == 3){
                csList.csListingActivity();
                csChoice = displayControl.csMainMenu();
            }
        }

        
    }
}