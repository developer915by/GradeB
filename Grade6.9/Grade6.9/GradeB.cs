using System;

public class GradeB
{
    private int total;
    private int gradeCounter;
    private int aCount;
    private int bCount;
    private int cCount;
    private int dCount;
    private int fCount;

    public string CourseName { get; set; }

    public GradeB(string name)
    {
        CourseName = name;
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Welcome\n{0}!\n", CourseName);
    }

    public void InputGrades()
    {
        int grade;
        string input;
        Console.WriteLine("{0}\n{1}",
            "Enter the integer grades in the range 0-100.", 
            "Type <Ctrl> z and press Enter to terminal input: ");
        input = Console.ReadLine();

        while (input != null )
        {
            grade = Convert.ToInt32(input);
            total += grade;
            ++gradeCounter;

            IncrementLetterGradeCounter(grade);
            input = Console.ReadLine();
        }
    }

    private void IncrementLetterGradeCounter ( int grade)
    {
        switch (grade/10)
        {
            case 9:
            case 10:
                ++aCount;
                break;
            case 8:
                ++bCount;
                break;
            case 7:
                ++cCount;
                break;
            case 6:
                ++dCount;
                break;
            default:
                ++fCount;
                break;
        }
    }

    public void DisplayGradeReport()
    {
        Console.WriteLine("\nGrade Report:");
            if (gradeCounter != 0)
        {
            double average = (double)total / gradeCounter;
            Console.WriteLine("Total of the {0} grades entered is {1}", gradeCounter, total);
            Console.WriteLine("Class average is {0:F}", average);
            Console.WriteLine("{0}A: {1}\nB: {2}\nC: {3}\nD: {4}\nF: {5}", "Number of studens who receved each: \n",
                aCount,
                bCount,
                cCount,
                dCount,
                fCount);
        }
        else
            Console.WriteLine("No grades were entered");
        Console.ReadKey();
    }
    
}