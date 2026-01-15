using System;

class Program
{
    static void Main(string[] args)
    {

        string gradeLetter;

        Console.Write("Enter your grade percentage to get a letter grade: ");
        string gradeInput = Console.ReadLine();

        int gradePercentage = int.Parse(gradeInput);

        if(gradePercentage >= 90)
        {
            gradeLetter = "A";
        } else if(gradePercentage >= 80)
        {
            gradeLetter = "B";
        } else if(gradePercentage >= 70)
        {
            gradeLetter = "C";
        } else if(gradePercentage >= 60)
        {
            gradeLetter = "D";
        } else if(gradePercentage < 60)
        {
            gradeLetter = "F";
        } else
        {
            gradeLetter = "undefined";
        }

        if (gradeLetter != "F")
        {
            if(gradeLetter != "A" && ((gradePercentage % 10) <= 7))
            {
                gradeLetter += "+";
            }else if((gradePercentage % 10) <= 3)
            {
                gradeLetter += "-";
            }
        }


        Console.WriteLine($"Your grade letter is an {gradeLetter}");
    }
}