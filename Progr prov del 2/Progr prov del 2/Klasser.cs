using System;
using System.Collections.Generic;
using System.Text;


class Klasser
{
    private static Random randGen = new Random(); // Slump generatorn

    public static int IsInt(string intake, string errorMessage, bool isMaxNumber, int maxNumber)
    {
        intake = intake.Trim();
        int amount;
        bool isInt = int.TryParse(intake, out amount);

        if (isMaxNumber == true && isInt == true)
        {
            if (amount > maxNumber)
            {
                isInt = false;

                while (isInt == false)
                {
                    WriteLine(errorMessage, false);
                    Console.ReadLine().Trim();
                    isInt = int.TryParse(intake, out amount);
                }
            }
        }

        while (isInt == false)
        {
            WriteLine(errorMessage, false);
            Console.ReadLine().Trim();
            isInt = int.TryParse(intake, out amount);
        }

        return amount;
    }

    public static void WriteLine(string text, bool ignoreReadLine)
    {
        Console.WriteLine(text);

        if (ignoreReadLine == true)
        {
            Console.ReadLine();
        }
    } //Skriver ut en string


    public static void Write(string text, bool ignoreReadLine)
    {
        Console.Write(text);

        if (ignoreReadLine == false)
        {
            Console.ReadLine();
        }
    } //Skriver ut med "Console.Write();" och denna metod ger chansen att ignorera "ReadLine"


    public static int RandInt(int num1, int num2)
    {
        int retVal; // retVal = return value

        retVal = randGen.Next(num1, num2 + 1);

        return retVal;
    }//Slumpar mellan två ints


    public static string RandString(string[] total)
    {
        int retVal; //retVal = return value

        retVal = randGen.Next(0, total.Length);

        return total[retVal];
    } //Slumpar en string från en string array

    public static void IsTrueString(string[] correct, string choice, string felMedelande)
    {
        bool x = true;
        while (x.Equals(true))
        {
            for (int i = 0; i < correct.Length; i++)
            {
                if (choice.ToLower().Trim() == correct[i])
                {
                    x = false;
                    break;
                }
            }
            if (x == true)
            {
                Console.WriteLine(felMedelande);

                choice = Console.ReadLine();
            }
        }
    }

    public static string IsTrueStringSpecial(string choice, bool noEmptySpace, string felMedellande)
    {
        if (noEmptySpace == true)
        {
            bool x = true;
            while (x.Equals(true))
            {
                if (choice.Trim() != "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(felMedellande);
                    choice = Console.ReadLine();
                }
            }
        }
        return choice;
    }
}

